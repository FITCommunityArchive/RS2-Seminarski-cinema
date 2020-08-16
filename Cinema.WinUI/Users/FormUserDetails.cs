using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Authorization;
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
    public partial class FormUserDetails : Form
    {

        private readonly ApiService _usersApi = new ApiService("Users");
        private readonly ApiService _rolesApi = new ApiService("Roles");
        private readonly string _id = null;
        private bool _isReadOnly = true;
        private UserUpsertRequest _request = new UserUpsertRequest();
        private IPagedList<ApplicationRoleDto> _roles = null;

        public FormUserDetails(string id = null)
        {
            InitializeComponent();
            _id = id;
            picLoading.Visible = false;
        }

        private async void FormUserDetails_Load(object sender, EventArgs e)
        {
            _roles = await _rolesApi.Get<PagedList<ApplicationRoleDto>>(null);


            if (!string.IsNullOrEmpty(_id))
            {
                await LoadReadOnly();
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

            SetReadonly(false);
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

        private void SetReadonly(bool isReadonly)
        {
            _isReadOnly = isReadonly;

            btnSaveChanges.Enabled = !isReadonly;
            //btnEdit.Enabled = isReadonly;

            txtFirstName.ReadOnly = _isReadOnly;
            txtLastName.ReadOnly = _isReadOnly;
            txtEmail.ReadOnly = _isReadOnly;
            txtPassword.ReadOnly = _isReadOnly;
            txtPassword2.ReadOnly = _isReadOnly;
            txtPhone.ReadOnly = _isReadOnly;
            txtUsername.ReadOnly = _isReadOnly;

            clbRoles.Visible = _isReadOnly;
        }

        private void LoadPropertyValues(ApplicationUserDto result)
        {
            txtFirstName.Text = result.FirstName;
            txtLastName.Text = result.LastName;
            txtUsername.Text = result.UserName;
            txtEmail.Text = result.Email;
            txtPhone.Text = result.PhoneNumber;
        }

        private async Task LoadReadOnly()
        {
            var result = await _usersApi.GetById<ApplicationUserDto>(_id);

            SetReadonly(true);

            LoadPropertyValues(result);

            List<ApplicationRoleDto> userRole = _roles.Data.Where(x => result.UserRoles.Select(y => y.RoleId).Contains(x.Id)).ToList();

            clbRoles.DataSource = userRole;
            clbRoles.DisplayMember = nameof(ApplicationRoleDto.Name);
        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {

            if(!this.ValidateChildren())
            {
                return;
            }

            if(txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Passwords don't match. Please make sure you typed in same password in both fields.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetLoading(true);

            var roleId = clbRoles.CheckedItems.Cast<ApplicationRoleDto>().Select(x => x.Id).FirstOrDefault();

            try
            {
                _request.UserName = txtUsername.Text;
                _request.Password = txtPassword.Text;
                _request.Email = txtEmail.Text;
                _request.FirstName = txtFirstName.Text;
                _request.LastName = txtLastName.Text;
                _request.PhoneNumber = txtPhone.Text;
                _request.RoleId = roleId;

                ApplicationUserDto result;

                result = await _usersApi.Insert<ApplicationUserDto>(_request);

                if(result != null)
                {
                    SetLoading(false);
                    MessageBox.Show("New user has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
