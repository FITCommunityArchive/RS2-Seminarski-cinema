using Cinema.WinUI.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormLogin : SecureBaseForm
    {
        ApiService _service = new ApiService("login");

        IList<string> _nextFormPrincipal;
        public FormLogin(IList<string> userPrincipal) : base (new string[] { "Guest" },userPrincipal)
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
                    SetLoading(false);
                    MessageBox.Show("You successufully logged in.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _nextFormPrincipal.Add(ApiService.Role);
                    FormMain form1 = new FormMain(_nextFormPrincipal);

                    this.Close();
                    form1.Show();
                    
                }
            }
            catch(Exception ex)
            {
                SetLoading(false);
                MessageBox.Show("Invalid credentials.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
