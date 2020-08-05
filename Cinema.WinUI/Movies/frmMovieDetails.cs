using Cinema.Models.Dtos;
using Cinema.Shared.Pagination;
using System;
using System.Linq;
using System.Windows.Forms;
using System;
using Utilities.BunifuButton.Transitions;
using System.Collections.Generic;
using System.Drawing;

namespace Cinema.WinUI.Movies
{
    public partial class frmMovieDetails : Form
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private readonly ApiService _genresApi = new ApiService("Genres");
        private readonly int? _id = null;
        private bool _isReadonly = true;

        public frmMovieDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            var result = await _moviesApi.GetById<MovieDto>(_id);
            var resultGenres = await _genresApi.Get<PagedList<GenreDto>>(null);

            SetReadonly();

            txtMovieTitle.Text = result.Title;
            txtReleaseYear.Text = result.Year.ToString();
            txtCountry.Text = result.Country;
            txtDirectors.Text = result.Directors;
            txtActors.Text = result.Actors;
            txtDuration.Text = result.Duration.ToString();

            if (string.IsNullOrWhiteSpace(result.Image))
            {

            }

            List<GenreDto> movieGenres = resultGenres.Data.Where(x => result.GenreMovies.Select(y => y.GenreId).Contains(x.Id)).ToList();

            if (_isReadonly)
            {
                lbxGenres.DataSource = movieGenres;
                lbxGenres.DisplayMember = nameof(GenreDto.Name);
            }
            else
            {
                chlGenres.DataSource = resultGenres.Data;
                chlGenres.DisplayMember = nameof(GenreDto.Name);

                for (int i = 0; i < chlGenres.Items.Count; i++)
                {
                    GenreDto genre = chlGenres.Items[i] as GenreDto;

                    if (result.GenreMovies.Select(x => x.GenreId).Contains(genre.Id))
                    {
                        chlGenres.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void ToggleReadonly()
        {
            _isReadonly = !_isReadonly;

            SetReadonly();
        }

        private void SetReadonly()
        {
            txtMovieTitle.ReadOnly = _isReadonly;
            txtReleaseYear.ReadOnly = _isReadonly;
            txtCountry.ReadOnly = _isReadonly;
            txtDirectors.ReadOnly = _isReadonly;
            txtActors.ReadOnly = _isReadonly;
            txtDuration.ReadOnly = _isReadonly;
            //chlGenres
        }
    }
}
