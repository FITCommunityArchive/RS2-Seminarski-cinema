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

        private MovieSearchRequest GetSearchRequest()
        {            
            string searchTerm = txtSearchBar.Text;

            MovieSearchRequest searchRequest = new MovieSearchRequest
            {
                PageIndex = pagination1.PageIndex,
                PageSize = 1            
            };

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
    }
}
