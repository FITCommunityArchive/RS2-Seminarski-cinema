using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.WinUI.Services;
using Cinema.Shared.Enums;

namespace Cinema.WinUI.Movies
{
    public partial class FormScreeningList : BaseDataGridForm
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private IList<string> _nextFormPrincipal;
        private bool _dateFilterCleared = true;

        public FormScreeningList(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private ScreeningSearchRequest GetSearchRequest()
        {
            ScreeningSearchRequest searchRequest = new ScreeningSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ScreeningSearchRequest;
            searchRequest.PageIndex = pagination.PageIndex;
            searchRequest.SearchTerm = txtSearchBar.Text;
            searchRequest.Hall = txtHall.Text;

            if (!_dateFilterCleared)
            {
                searchRequest.Date = dtpScreeningDate.Value;
            }
            else
            {
                searchRequest.Date = null;
            }

            Enum.TryParse(cmbStatus.SelectedValue.ToString(), out TimingStatus timingStatus);
            searchRequest.Status = timingStatus;

            AddIncludes(ref searchRequest);

            if (int.TryParse(txtPrice.Text, out int searchPrice))
            {
                searchRequest.Price = searchPrice;
            }

            return searchRequest;
        }

        private static ScreeningSearchRequest AddIncludes(ref ScreeningSearchRequest searchRequest)
        {
            searchRequest.Includes.Add("Movie");
            searchRequest.Includes.Add("Hall");
            searchRequest.Includes.Add("Pricing");

            return searchRequest;
        }

        private async Task LoadScreenings(ScreeningSearchRequest searchRequest)
        {
            var result = await _screeningsApi.Get<PagedList<ScreeningDto>>(searchRequest);

            grdScreeningsList.AutoGenerateColumns = false;
            grdScreeningsList.DataSource = result.Data;
            pagination.PageIndex = result.PageIndex;
            pagination.TotalPages = result.TotalPages;
        }

        private void InitializeDetailsForm(int? id)
        {
            /*
            _frmMovieDetails = new FormMovieDetails(id);
            _frmMovieDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDetails_Closed);
            _frmMovieDetails.ShowDialog();*/
        }

        #region Event methods

        private async void FormScreeningList_Load(object sender, EventArgs e)
        {
            this.grdScreeningsList.DoubleBuffered(true);
            ScreeningSearchRequest searchRequest = new ScreeningSearchRequest();
            AddIncludes(ref searchRequest);

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ScreeningSearchRequest;

            cmbStatus.DataSource = Enum.GetValues(typeof(TimingStatus));
            cmbStatus.SelectedItem = TimingStatus.SCHEDULED;

            await LoadScreenings(searchRequest);
        }

        private async void pagination_PageChanged(object sender, EventArgs e)
        {
            ScreeningSearchRequest searchRequest = GetSearchRequest();
            await LoadScreenings(searchRequest);
        }

        private async void grdScreeningsList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdScreeningsList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            ScreeningSearchRequest searchRequest = GetSearchRequest();
            searchRequest.SortColumn = CurrentSortPropertyName;
            searchRequest.SortOrder = CurrentSortOrder;

            await LoadScreenings(searchRequest);
        }

        private void grdScreeningsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int.TryParse(clickedRow.Cells["id"].Value.ToString(), out int filmId);

                InitializeDetailsForm(filmId);
            }
        }

        private void FormDetails_Closed(object sender, EventArgs e)
        {
            FormScreeningList_Load(sender, e);
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            ScreeningSearchRequest searchRequest = GetSearchRequest();
            await LoadScreenings(searchRequest);
        }

        #endregion

        private void grdScreeningsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(grdScreeningsList, sender, e);
        }

        private void dtpScreeningDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpScreeningDate.CustomFormat = " ";
                dtpScreeningDate.Format = DateTimePickerFormat.Custom;
                _dateFilterCleared = true;
            }

            SearchChanged(sender, e);
        }

        private void dtpScreeningDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpScreeningDate.Format == DateTimePickerFormat.Custom)
            {
                dtpScreeningDate.Format = DateTimePickerFormat.Short;
            }

            _dateFilterCleared = false;
            SearchChanged(sender, e);
        }
    }
}
