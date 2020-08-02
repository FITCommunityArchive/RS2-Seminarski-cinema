using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class LoginForm : Form
    {
        ApiService _service = new ApiService("login");
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ApiService.Username = txtUsername.Text;
                ApiService.Password = txtPassword.Text;

                var maybeLogin = await _service.AuthUser();
                if(maybeLogin == true)
                {
                    MessageBox.Show("You successufully logged in.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Invalid credentials.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
