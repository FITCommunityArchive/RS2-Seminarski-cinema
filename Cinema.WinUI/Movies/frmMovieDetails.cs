using Cinema.Models;
using System;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class frmMovieDetails : Form
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private readonly int _id;

        public frmMovieDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            var result = await _moviesApi.GetById<MovieDto>(_id);

            txtMovieTitle.Text = result.Title;
            txtReleaseYear.Text = result.Year.ToString();
            txtCountry.Text = result.Country;
            txtDirectors.Text = result.Directors;
            txtActors.Text = result.Actors;
            txtDuration.Text = result.Duration.ToString();           
        }
    }
}
