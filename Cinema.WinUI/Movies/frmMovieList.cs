using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Constants;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class frmMovieList : BaseDataGridForm
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");

        private IList<string> _nextFormPrincipal;
        public frmMoviesList(IList<string> userPrincipal) : base(new string[] { "Administrator", "Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void frmMoviesList_Load(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = new MovieSearchRequest();
            searchRequest = ApplyDefaultSearchValues(searchRequest) as MovieSearchRequest;
            await LoadMovies(searchRequest);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
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

                frmMovieDetails frmMovieDetails = new frmMovieDetails(filmId);
                frmMovieDetails.ShowDialog();
            }
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            frmMovieDetails frmMovieDetails = new frmMovieDetails();
            frmMovieDetails.ShowDialog();
        }
    }
}
