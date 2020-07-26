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
        private int _pageIndex;
        private int _totalPages;

        public frmMoviesList()
        {
            InitializeComponent();
        }

        private async void frmMoviesList_Load(object sender, EventArgs e)
        {
            MovieSearchRequest searchRequest = new MovieSearchRequest
            {
                PageIndex = 1,
                PageSize = 1
            };

            await LoadMovies(searchRequest);
        }

        private async void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            await LoadFilteredMovies();
        }

        private async void txtSearchYear_TextChanged(object sender, EventArgs e)
        {
           await LoadFilteredMovies();
        }

        private async void txtSearchDuration_TextChanged(object sender, EventArgs e)
        {
            await LoadFilteredMovies();
        }

        private async Task LoadFilteredMovies()
        {            
            string searchTerm = txtSearchBar.Text;

            MovieSearchRequest searchRequest = new MovieSearchRequest();

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

            if (searchRequest.Duration.HasValue || searchRequest.Year.HasValue || searchRequest.SearchTerm != null)
            {
                await LoadMovies(searchRequest);
            }                     
        }

        private async Task LoadMovies(MovieSearchRequest searchRequest)
        {
            var result = await _moviesApi.Get<PagedList<MovieDto>>(searchRequest);

            grdMoviesList.AutoGenerateColumns = false;
            grdMoviesList.DataSource = result.Data;
            rtxCurrentPage.Text = result.PageIndex.ToString();
            rtxLastPage.Text = result.TotalPages.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
