using Cinema.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Models;
using Cinema.Models.Requests;

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
            var result = await _moviesApi.Get<PagedList<MovieDto>>(new MovieSearchRequest());       
            grdMoviesList.DataSource = result;
        }

        private Task LoadMovies()
        {
            throw new NotImplementedException();
        }
    }
}
