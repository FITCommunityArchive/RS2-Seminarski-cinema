using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Users
{
    public partial class FormUserDetails : Form
    {

        private readonly ApiService _usersApi = new ApiService("Users");
        private readonly ApiService _rolesApi = new ApiService("Roles");
        private readonly int? _id = null;
        private UserInsertRequest _request = new UserInsertRequest();
        private UserUpdateRequest _update = new UserUpdateRequest();
        private IPagedList<ApplicationRoleDto> _roles = null;

        public event EventHandler ItemDeleted;

        public FormUserDetails(int? id)
        {
            InitializeComponent();
            _id = id;
            picLoading.Visible = false;
            gbRoles.Controls.OfType<RadioButton>().First().Checked = true;

            if (_id.HasValue)
            {
                txtConfirmPassword.Visible = false;
                txtPassword.Visible = false;
                lblPasswordConfirm.Visible = false;
                lblPassword.Visible = false;
            }
            else
            {
                btnChangePassword.Visible = false;
                btnDelete.Visible = false;
            }
        }

        protected virtual void OnItemDeleted(EventArgs e)
        {
            ItemDeleted?.Invoke(this, e);
        }

        private async void FormUserDetails_Load(object sender, EventArgs e)
        {
            _roles = await _rolesApi.Get<PagedList<ApplicationRoleDto>>(null);


            if (_id.HasValue)
            {
                await LoadData();
            }
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoading.Visible = true;
                    btnSaveChanges.Enabled = false;
                    Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoading.Visible = false;
                    btnSaveChanges.Enabled = true;
                    Cursor = Cursors.Default;
                });
            }
        }

        private void LoadPropertyValues(ApplicationUserDto result)
        {
            txtFirstName.Text = result.FirstName;
            txtLastName.Text = result.LastName;
            txtUsername.Text = result.UserName;
            txtEmail.Text = result.Email;
            txtPhone.Text = result.PhoneNumber;
        }

        private async Task LoadData()
        {
            var result = await _usersApi.GetById<ApplicationUserDto>(_id);

            LoadPropertyValues(result);

            ApplicationRoleDto userRole = _roles.Data.Where(x => result.UserRoles.Select(y => y.RoleId).Contains(x.Id)).FirstOrDefault();

            var roleRBtn = gbRoles.Controls.OfType<RadioButton>().Where(x => x.Text.ToLower() == userRole.Name.ToLower()).FirstOrDefault();
            roleRBtn.Checked = true;
        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            string message = "";
            if (!this.ValidateChildren())
            {
                return;
            }

            SetLoading(true);

            var checkedRBtn = gbRoles.Controls.OfType<RadioButton>().Where(x => x.Checked == true).FirstOrDefault();
            int.TryParse(checkedRBtn.Tag.ToString(), out int roleId);
            try
            {

                ApplicationUserDto result;

                if (_id.HasValue)
                {
                    _update.UserName = txtUsername.Text;
                    _update.Email = txtEmail.Text;
                    _update.FirstName = txtFirstName.Text;
                    _update.LastName = txtLastName.Text;
                    _update.PhoneNumber = txtPhone.Text;
                    _update.RoleId = roleId;

                    result = await _usersApi.Update<ApplicationUserDto>(_id, _update);
                    message = "Changes saved.";
                }
                else
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Passowrds do not match.Make sure you type in same password in both fields", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _request.UserName = txtUsername.Text;
                    _request.Email = txtEmail.Text;
                    _request.FirstName = txtFirstName.Text;
                    _request.LastName = txtLastName.Text;
                    _request.PhoneNumber = txtPhone.Text;
                    _request.RoleId = roleId;
                    _request.Password = txtPassword.Text;
                    result = await _usersApi.Insert<ApplicationUserDto>(_request);
                    message = "New user has been added.";
                }

                if (result != null)
                {
                    SetLoading(false);
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (_id.HasValue)
            {
                FormChangePassword formChangePassword = new FormChangePassword((int)_id);
                formChangePassword.ShowDialog();
            }
        }

        private async void btnDelete_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await _usersApi.Delete<ApplicationUserDto>(_id);
                if (result != null)
                {
                    MessageBox.Show("User deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPassword.Visible && txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(sender as TextBox, Properties.Resources.Validation_PasswortMismatch);
                e.Cancel = true;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateEmptyField(txtUsername, e))
            {
                ValidateFieldMin3Char(txtUsername, e);
            }

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateEmptyField(txtFirstName, e))
            {
                ValidateFieldMin3Char(txtFirstName, e);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateEmptyField(txtLastName, e))
            {
                ValidateFieldMin3Char(txtLastName, e);
            }

        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateEmptyField(txtPhone, e))
            {
                ValidatePhone(txtPhone, e);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateEmptyField(txtEmail, e))
            {
                ValidateEmail(txtEmail, e);
            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtPassword.Visible && ValidateEmptyField(txtPassword, e))
            {
                ValidatePassword(txtPassword, e);
            }

        }

        private bool ValidateEmptyField(Control control, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
                return false;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
            return true;
        }

        private void ValidatePassword(Control control, CancelEventArgs e)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$";
            Regex r = new Regex(pattern);
            if (!r.IsMatch(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_InvalidPassword);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void ValidatePhone(Control control, CancelEventArgs e)
        {
            string pattern = "^([0-9]{9})$";
            Regex r = new Regex(pattern);
            if (!r.IsMatch(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_InvalidPhone);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void ValidateEmail(Control control, CancelEventArgs e)
        {
            string pattern = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex r = new Regex(pattern);
            if (!r.IsMatch(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_InvalidEmail);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void ValidateFieldMin3Char(Control control, CancelEventArgs e)
        {
            if (control.Text.Length < 3)
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Min3Char);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

    }
}
