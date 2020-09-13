using Cinema.WinUI.Authorization;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormLogin : SecureBaseForm
    {
        ApiService _service = new ApiService("login");

        IList<string> _nextFormPrincipal;
        public FormLogin(IList<string> userPrincipal) : base(new string[] { "Guest", "Administrator", "Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
            picLoading.Visible = false;
            picLoading.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoading.Visible = true;
                    btnLogin.Enabled = false;
                    Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoading.Visible = false;
                    btnLogin.Enabled = true;
                    Cursor = Cursors.Default;
                });
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            try
            {
                ApiService.Username = txtUsername.Text;
                ApiService.Password = txtPassword.Text;

                var maybeLogin = await _service.AuthUser();

                if (maybeLogin == true)
                {

                    if (ApiService.Role.Equals("Customer"))
                    {
                        SetLoading(false);
                        MessageBox.Show("Customers are not allowed to use dashboard.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SetLoading(false);
                        MessageBox.Show("You successufully logged in.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _nextFormPrincipal.Clear();
                        _nextFormPrincipal.Add(ApiService.Role);
                        FormMain form1 = new FormMain(_nextFormPrincipal);

                        this.Close();
                        form1.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show("Invalid credentials.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
