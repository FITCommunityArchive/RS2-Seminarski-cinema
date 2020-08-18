using Cinema.Models.Requests.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Users
{
    public partial class FormChangePassword : Form
    {

        private readonly ApiService _authApi = new ApiService("Users");
        private UserPasswordResetRequest _request = new UserPasswordResetRequest();
        private readonly int _userId;
        public FormChangePassword(int id)
        {
            _userId = id;
            InitializeComponent();
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords don't match. Please make sure you typed in same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _request.NewPassword = txtNewPassword.Text;
                _request.Token = await _authApi.ResetPasswordToken(_userId);

                var result = await _authApi.ResetPassword(_userId, _request);
                if (result == true)
                {
                    MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
