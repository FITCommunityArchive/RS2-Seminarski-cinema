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
            MovieSearchRequest searchRequest = new MovieSearchRequest();
            await LoadMovies(searchRequest);
        }

        private async Task LoadMovies(MovieSearchRequest searchRequest)
        {
            var result = await _moviesApi.Get<PagedList<MovieDto>>(searchRequest);

            grdMoviesList.AutoGenerateColumns = false;
            grdMoviesList.DataSource = result;
        }

        private async void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBar.Text;

            if (searchTerm.Count() < Search.MINIMUM_SEARCH_CHARACTERS) return;

            MovieSearchRequest searchRequest = new MovieSearchRequest
            {
                SearchTerm = searchTerm
            };

            await LoadMovies(searchRequest);
        }
    }
}
