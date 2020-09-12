using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            else
            {
                InsertNew();
            }
        }

        private void InsertNew()
        {
            clbRoles.DataSource = _roles.Data;
            clbRoles.DisplayMember = nameof(ApplicationRoleDto.Name);
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
    }
}
