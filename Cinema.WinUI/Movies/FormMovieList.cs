using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.WinUI.Services;

namespace Cinema.WinUI.Movies
{
    public partial class FormMovieList : BaseDataGridForm
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private IList<string> _nextFormPrincipal;
        private FormMovieDetails _frmMovieDetails = null;

        public FormMovieList(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private MovieSearchRequest GetSearchRequest()
        {
            MovieSearchRequest searchRequest = new MovieSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as MovieSearchRequest;
            searchRequest.PageIndex = pgnMoviesList.PageIndex;
            searchRequest.SearchTerm = txtSearchBar.Text;

            if (int.TryParse(txtSearchDuration.Text, out int searchDuration))
            {
                searchRequest.Duration = searchDuration;
            }

            if (int.TryParse(txtSearchYear.Text, out int searchYear))
            {
                searchRequest.Year = searchYear;
            }

            return searchRequest;
        }

        private async Task LoadMovies(MovieSearchRequest searchRequest)
        {
            var result = await _moviesApi.Get<PagedList<MovieDto>>(searchRequest);

            grdMoviesList.AutoGenerateColumns = false;
            grdMoviesList.DataSource = result.Data;
            pgnMoviesList.PageIndex = result.PageIndex;
            pgnMoviesList.TotalPages = result.TotalPages;
        }

        private void InitializeDetailsForm(int? id)
        {
            _frmMovieDetails = new FormMovieDetails(id);
            _frmMovieDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDetails_Closed);
            _frmMovieDetails.ShowDialog();
        }

        #region Event methods

        private async void pgnMoviesList_PageChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        private async void grdMoviesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdMoviesList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            MovieSearchRequest searchRequest = GetSearchRequest();
            searchRequest.SortColumn = CurrentSortPropertyName;
            searchRequest.SortOrder = CurrentSortOrder;

            await LoadMovies(searchRequest);
        }

        private void grdMoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            frmMoviesList_Load(sender, e);
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private async void frmMoviesList_Load(object sender, EventArgs e)
        {
            this.grdMoviesList.DoubleBuffered(true);
            MovieSearchRequest searchRequest = new MovieSearchRequest();
            searchRequest = ApplyDefaultSearchValues(searchRequest) as MovieSearchRequest;
            await LoadMovies(searchRequest);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        #endregion
    }
}
