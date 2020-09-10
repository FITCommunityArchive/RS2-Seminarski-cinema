using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.Events;
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

namespace Cinema.WinUI.Events
{
    public partial class FormEventsList : BaseDataGridForm
    {
        private readonly ApiService _eventsApi = new ApiService("Events");
        private readonly ApiService _eventTypesApi = new ApiService("EventTypes");
        private IPagedList<EventTypeDto> _eventTypes = null;
        private IList<string> _nextFormPrincipal;
        private bool _dateFilterCleared = true;
        private FormEventDetails _formEventDetails = null;

        public FormEventsList(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }


        private EventSearchRequest GetSearchRequest()
        {
            EventSearchRequest searchRequest = new EventSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as EventSearchRequest;
            searchRequest.PageIndex = pagination.PageIndex;
            searchRequest.Title = txtSearchBar.Text;
            searchRequest.Author = txtAuthor.Text;
            searchRequest.Promoter = txtPromoter.Text;

            if (!_dateFilterCleared)
            {
                searchRequest.DateAndTime = dtpEventDate.Value.ToUniversalTime();
            }
            else
            {
                searchRequest.DateAndTime = null;
            }

            if (cmbType.SelectedValue != null && int.TryParse(cmbType.SelectedValue.ToString(), out int typeId))
            {
                searchRequest.TypeId = typeId;
            }

            AddIncludes(ref searchRequest);

            return searchRequest;
        }

        private static EventSearchRequest AddIncludes(ref EventSearchRequest searchRequest)
        {
            searchRequest.Includes.Add("Author");
            searchRequest.Includes.Add("Type");
            return searchRequest;
        }

        private async Task LoadNews(EventSearchRequest searchRequest)
        {
            var result = await _eventsApi.Get<PagedList<EventDto>>(searchRequest);

            grdList.AutoGenerateColumns = false;
            grdList.DataSource = result.Data;
            pagination.PageIndex = result.PageIndex;
            pagination.TotalPages = result.TotalPages;
        }

        private void InitializeDetailsForm(int? id)
        {
            _formEventDetails = new FormEventDetails(id);
            _formEventDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDetails_Closed);
            _formEventDetails.ShowDialog();
        }

        #region Event methods

        private async void FormEventsList_Load(object sender, EventArgs e)
        {
            this.grdList.DoubleBuffered(true);
            EventSearchRequest searchRequest = new EventSearchRequest();
            AddIncludes(ref searchRequest);

            searchRequest = ApplyDefaultSearchValues(searchRequest) as EventSearchRequest;

            _eventTypes = await _eventTypesApi.Get<PagedList<EventTypeDto>>(new BaseSearchRequest());

            await LoadNews(searchRequest);
        }

        private async void pagination_PageChanged(object sender, EventArgs e)
        {
            EventSearchRequest searchRequest = GetSearchRequest();
            await LoadNews(searchRequest);
        }

        private async void grdList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            EventSearchRequest searchRequest = GetSearchRequest();
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
                int.TryParse(clickedRow.Cells["id"].Value.ToString(), out int eventId);

                InitializeDetailsForm(eventId);
            }
        }

        private void FormDetails_Closed(object sender, EventArgs e)
        {
            FormEventsList_Load(sender, e);
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            EventSearchRequest searchRequest = GetSearchRequest();
            await LoadNews(searchRequest);
        }

        private void grdList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(grdList, sender, e);
        }

        private void cmbType_Click(object sender, EventArgs e)
        {
            if (cmbType.DataSource == null)
            {
                cmbType.DataSource = _eventTypes.Data;
                cmbType.DisplayMember = nameof(NewsTypeDto.Name);
                cmbType.ValueMember = nameof(NewsTypeDto.Id);

                /* The handler is added code-first in order to prevent the SearchChanged method being triggered
                * in the value initialisation for status above.*/
                cmbType.SelectedIndexChanged += new EventHandler(SearchChanged);
            }
        }

        private void dtpEventDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpEventDate.CustomFormat = " ";
                dtpEventDate.Format = DateTimePickerFormat.Custom;
                _dateFilterCleared = true;
            }

            SearchChanged(sender, e);
        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEventDate.Format == DateTimePickerFormat.Custom)
            {
                dtpEventDate.Format = DateTimePickerFormat.Short;
            }

            _dateFilterCleared = false;
            SearchChanged(sender, e);
        }

        #endregion
    }
}
