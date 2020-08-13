using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WinUI.Users
{
    public partial class FormUsers : BaseDataGridForm
    {


        private ApiService _usersApi = new ApiService("Users");
        IList<string> _nextFormPrincipal;
        public FormUsers(IList<string> userPrincipal) : base(new string[] { "Administrator" }, userPrincipal)
        {
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

    }
}
