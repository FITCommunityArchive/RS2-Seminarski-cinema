using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Authorization;
using Cinema.WinUI.Helpers;
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
    public partial class FormUsers : BaseDataGridForm
    {

        private ApiService _usersApi = new ApiService("Users");
        IList<string> _nextFormPrincipal;
        public FormUsers(IList<string> userPrincipal) : base(new string[] { "Administrator" }, userPrincipal) {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
            this.dgvUsers.DoubleBuffered(true);
            UserSearchRequest userSearchRequest = new UserSearchRequest();
            userSearchRequest = ApplyDefaultSearchValues(userSearchRequest) as UserSearchRequest;
            await LoadUsers(userSearchRequest);
        }

        private async Task LoadUsers(UserSearchRequest req)
        {
            var result = await _usersApi.Get<PagedList<ApplicationUserDto>>(req);
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = result.Data;
            pgnUsers.PageIndex = result.PageIndex;
            pgnUsers.TotalPages = result.TotalPages;

        }

        private async void pgnUsersList_PageChanged(object sender, EventArgs e)
        {
            UserSearchRequest searchRequest = GetSearchRequest();
            await LoadUsers(searchRequest);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UserSearchRequest searchRequest = GetSearchRequest();
            await LoadUsers(searchRequest);
        }

        private UserSearchRequest GetSearchRequest()
        {
            UserSearchRequest searchRequest = new UserSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as UserSearchRequest;
            searchRequest.PageIndex = pgnUsers.PageIndex;
            searchRequest.searchTerm = txtSearch.Text;

            return searchRequest;
        }

        private void BtnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                var userId = clickedRow.Cells["Id"].Value.ToString();

                InitializeDetailsForm(userId);
            }
        }

        private void FormDetails_Closed(object sender, EventArgs e)
        {
            FormUsers_Load(sender, e);
        }

        private void InitializeDetailsForm(string id)
        {
            FormUserDetails frmUserDetails = new FormUserDetails(id);
            frmUserDetails.FormClosed += new FormClosedEventHandler(FormDetails_Closed);
            frmUserDetails.ShowDialog();
        }
    }
}
