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
    public partial class FormUsers : BaseDataGridForm
    {


        private ApiService _usersApi = new ApiService("Users");
        IList<string> _nextFormPrincipal;
        public FormUsers(IList<string> userPrincipal) : base(new string[] { "Guest" }, userPrincipal) {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
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

    }
}
