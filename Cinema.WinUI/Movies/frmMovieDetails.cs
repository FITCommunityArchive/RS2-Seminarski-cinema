using Cinema.Models.Dtos;
using Cinema.Shared.Pagination;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Cinema.Models.Requests.Movies;
using System.ComponentModel;

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
            var resultGenres = await _genresApi.Get<PagedList<GenreDto>>(null);

            if (_id.HasValue)
            {
                await LoadReadOnly(resultGenres);
            }
            else
            {
                InsertNew(resultGenres);
            }

        }

        private void InsertNew(PagedList<GenreDto> resultGenres)
        {
            chlGenres.DataSource = resultGenres.Data;
            chlGenres.DisplayMember = nameof(GenreDto.Name);

            SetGenresListReadonly(false);
        }


        private async Task LoadReadOnly(PagedList<GenreDto> genres)
        {
            var result = await _moviesApi.GetById<MovieDto>(_id);            

            SetReadonly();

            txtMovieTitle.Text = result.Title;
            txtReleaseYear.Text = result.Year.ToString();
            txtCountry.Text = result.Country;
            txtDirectors.Text = result.Directors;
            txtActors.Text = result.Actors;
            txtDuration.Text = result.Duration.ToString();

            List<GenreDto> movieGenres = genres.Data.Where(x => result.GenreMovies.Select(y => y.GenreId).Contains(x.Id)).ToList();

            if (_isReadonly)
            {
                lbxGenres.DataSource = movieGenres;
                lbxGenres.DisplayMember = nameof(GenreDto.Name);
            }
            else
            {
                chlGenres.DataSource = genres.Data;
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

        private void SetGenresListReadonly(bool isReadonly)
        {
            lbxGenres.Visible = isReadonly;
            chlGenres.Visible = !isReadonly;
        }

        private void SetReadonly()
        {
            txtMovieTitle.ReadOnly = _isReadonly;
            txtReleaseYear.ReadOnly = _isReadonly;
            txtCountry.ReadOnly = _isReadonly;
            txtDirectors.ReadOnly = _isReadonly;
            txtActors.ReadOnly = _isReadonly;
            txtDuration.ReadOnly = _isReadonly;
            SetGenresListReadonly(true);
        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            MovieUpsertRequest request = new MovieUpsertRequest
            {
                Actors = txtActors.Text,
                Country = txtCountry.Text,
                Directors = txtDirectors.Text,
                Duration = int.Parse(txtDuration.Text),
                Title = txtMovieTitle.Text,
                Year = int.Parse(txtReleaseYear.Text)
            };

            //await _moviesApi.Insert<MovieUpsertRequest>(request);
        }

        private void txtReleaseYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_isReadonly) return;
            ValidateInteger(txtReleaseYear, e);
        }

        private void ValidateEmptyField(Control control, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void ValidateInteger(Control control, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(control.Text, out int result))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_IntegerRequired);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }
    }
}
