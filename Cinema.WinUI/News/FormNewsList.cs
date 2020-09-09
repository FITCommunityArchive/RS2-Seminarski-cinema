using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.News;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Screenings;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.News
{
    public partial class FormNewsList : BaseDataGridForm
    {
        private readonly ApiService _newsApi = new ApiService("News");
        private readonly ApiService _newsTypesApi = new ApiService("NewsTypes");
        private IPagedList<NewsTypeDto> _newsTypes = null;
        private IList<string> _nextFormPrincipal;
        private FormNewsDetails _formNewsDetails = null;

        public FormNewsList(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }


        private NewsSearchRequest GetSearchRequest()
        {
            NewsSearchRequest searchRequest = new NewsSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as NewsSearchRequest;
            searchRequest.PageIndex = pagination.PageIndex;
            searchRequest.Title = txtSearchBar.Text;
            searchRequest.Author = txtAuthor.Text;

            if (cmbType.SelectedValue != null && int.TryParse(cmbType.SelectedValue.ToString(), out int typeId))
            {
                searchRequest.TypeId = typeId;
            }

            AddIncludes(ref searchRequest);

            return searchRequest;
        }

        private static NewsSearchRequest AddIncludes(ref NewsSearchRequest searchRequest)
        {
            searchRequest.Includes.Add("Author");
            searchRequest.Includes.Add("Type");
            return searchRequest;
        }

        private async Task LoadNews(NewsSearchRequest searchRequest)
        {
            var result = await _newsApi.Get<PagedList<NewsDto>>(searchRequest);

            grdList.AutoGenerateColumns = false;
            grdList.DataSource = result.Data;
            pagination.PageIndex = result.PageIndex;
            pagination.TotalPages = result.TotalPages;
        }

        private void InitializeDetailsForm(int? id)
        {
            _formNewsDetails = new FormNewsDetails(id);
            _formNewsDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDetails_Closed);
            _formNewsDetails.ShowDialog();
        }

        #region Event methods

        private async void FormNewsList_Load(object sender, EventArgs e)
        {
            this.grdList.DoubleBuffered(true);
            NewsSearchRequest searchRequest = new NewsSearchRequest();
            AddIncludes(ref searchRequest);

            searchRequest = ApplyDefaultSearchValues(searchRequest) as NewsSearchRequest;

            _newsTypes = await _newsTypesApi.Get<PagedList<NewsTypeDto>>(new BaseSearchRequest());

            await LoadNews(searchRequest);
        }

        private async void pagination_PageChanged(object sender, EventArgs e)
        {
            NewsSearchRequest searchRequest = GetSearchRequest();
            await LoadNews(searchRequest);
        }

        private async void grdList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            NewsSearchRequest searchRequest = GetSearchRequest();
            searchRequest.SortColumn = CurrentSortPropertyName;
            searchRequest.SortOrder = CurrentSortOrder;

            await LoadNews(searchRequest);
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int.TryParse(clickedRow.Cells["id"].Value.ToString(), out int newsId);

                InitializeDetailsForm(newsId);
            }
        }

        private void FormDetails_Closed(object sender, EventArgs e)
        {
            FormNewsList_Load(sender, e);
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            NewsSearchRequest searchRequest = GetSearchRequest();
            await LoadNews(searchRequest);
        }

        #endregion

        private void grdList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(grdList, sender, e);
        }

        private void cmbType_Click(object sender, EventArgs e)
        {
            if (cmbType.DataSource == null)
            {
                cmbType.DataSource = _newsTypes.Data;
                cmbType.DisplayMember = nameof(NewsTypeDto.Name);
                cmbType.ValueMember = nameof(NewsTypeDto.Id);

                /* The handler is added code-first in order to prevent the SearchChanged method being triggered
                * in the value initialisation for status above.*/
                cmbType.SelectedIndexChanged += new EventHandler(SearchChanged);
            }
        }
    }
}
