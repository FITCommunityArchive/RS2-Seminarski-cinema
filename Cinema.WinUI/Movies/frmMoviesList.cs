using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared;
using Cinema.WinUI.Constants;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class frmMoviesList : Form
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private string _currentSortPropertyName { get; set; }
        private Cinema.Shared.Enums.SortOrder? _currentSortOrder { get; set; }

        public frmMoviesList()
        {
            InitializeComponent();
        }

        private async void frmMoviesList_Load(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetDefaultSearchRequest();
            await LoadMovies(searchRequest);
        }

        private async void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        private async void txtSearchYear_TextChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        private async void txtSearchDuration_TextChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        private MovieSearchRequest GetDefaultSearchRequest()
        {
            return new MovieSearchRequest
            {
                PageIndex = pagination1.PageIndex,
                PageSize = Paging.DEFAULT_PAGE_SIZE
            };
        }

        private MovieSearchRequest GetSearchRequest()
        {            
            string searchTerm = txtSearchBar.Text;

            MovieSearchRequest searchRequest = GetDefaultSearchRequest();

            if (searchTerm.Count() >= Search.MINIMUM_SEARCH_CHARACTERS || searchTerm.Count() == 0)
            {
                searchRequest.SearchTerm = searchTerm;                
            }

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void pagination1_PageChanged(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = GetSearchRequest();
            await LoadMovies(searchRequest);
        }

        private void grdMoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void grdMoviesList_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdMoviesList.Columns[e.ColumnIndex];

            _currentSortPropertyName = clickedColumn.Name;
            _currentSortOrder = Shared.Enums.SortOrder.ASC;

            MovieSearchRequest searchRequest = GetSearchRequest();
            searchRequest.SortColumn = _currentSortPropertyName;
            searchRequest.SortOrder = _currentSortOrder;

            await LoadMovies(searchRequest);
        }
    }
}
