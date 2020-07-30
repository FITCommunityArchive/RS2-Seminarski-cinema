using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Constants;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class frmMoviesList : BaseDataGridForm
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");

        public frmMoviesList()
        {
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
            searchRequest.PageIndex = pagination1.PageIndex;
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
            pagination1.PageIndex = result.PageIndex;
            pagination1.TotalPages = result.TotalPages;
        }

        private async void pagination1_PageChanged(object sender, EventArgs e)
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
    }
}
