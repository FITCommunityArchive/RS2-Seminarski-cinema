using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.WinUI.Services;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.Requests;

namespace Cinema.WinUI.Movies
{
    public partial class FormScreeningDetails : Form
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private readonly ApiService _hallsApi = new ApiService("Halls");
        private readonly ApiService _pricingsApi = new ApiService("Pricings");
        private readonly int? _id = null;
        private ScreeningUpsertRequest _request = new ScreeningUpsertRequest();
        private IPagedList<MovieDto> _movies = null;
        private IPagedList<HallDto> _halls = null;
        private IPagedList<PricingDto> _pricings = null;

        public event EventHandler ItemDeleted;

        public FormScreeningDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        protected virtual void OnItemDeleted(EventArgs e)
        {
            ItemDeleted?.Invoke(this, e);
        }

        private void InsertNew()
        {/*
            chlGenres.DataSource = _genres.Data;
            chlGenres.DisplayMember = nameof(GenreDto.Name);*/
        }


        private async Task LoadReadOnly()
        {
            IncludesSearchRequest searchRequest = new IncludesSearchRequest
            {
                Includes = new List<string>
                {
                    "Movie", "Hall", "Pricing"
                }
            };

            var result = await _screeningsApi.GetById<ScreeningDto>(_id, searchRequest);

            LoadPropertyValues(result);
        }

        private async Task LoadEdit()
        {
            /*var resultGenres = await _genresApi.Get<PagedList<GenreDto>>(null);
            var result = await _screeningsApi.GetById<MovieDto>(_id);

            SetReadonly(false);

            LoadPropertyValues(result);

            List<GenreDto> movieGenres = resultGenres.Data.Where(x => result.GenreMovies.Select(y => y.GenreId).Contains(x.Id)).ToList();*/

            /*
            chlGenres.DataSource = resultGenres.Data;
            chlGenres.DisplayMember = nameof(GenreDto.Name);

            for (int i = 0; i < chlGenres.Items.Count; i++)
            {
                GenreDto genre = chlGenres.Items[i] as GenreDto;

                if (result.GenreMovies.Select(x => x.GenreId).Contains(genre.Id))
                {
                    chlGenres.SetItemChecked(i, true);
                }
            }*/
        }

        private void LoadPropertyValues(ScreeningDto result)
        {
            dtpScreeningDate.Value = result.DateAndTime;

            cmbMovie.DataSource = _movies.Data;
            cmbMovie.DisplayMember = nameof(MovieDto.Title);
            cmbMovie.ValueMember = nameof(MovieDto.Id);
            cmbMovie.SelectedItem = result.Movie;
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

        #region Event methods

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            _movies = await _moviesApi.Get<PagedList<MovieDto>>(new MovieSearchRequest
            {
                ReturnAll = true
            });
/*            PagedList<HallDto> _halls = await _hallsApi.Get<PagedList<HallDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });
            PagedList<PricingDto> _pricings = await _pricingsApi.Get<PagedList<PricingDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });*/

            if (_id.HasValue)
            {
                await LoadReadOnly();
            }
            else
            {
                InsertNew();
            }

        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            /*
            List<int> movieGenreIds = chlGenres.CheckedItems.Cast<GenreDto>().Select(x => x.Id).ToList();

            _request.Actors = txtActors.Text;
            _request.Country = txtCountry.Text;
            _request.Directors = txtDirectors.Text;
            _request.Writers = txtWriters.Text;
            _request.Duration = int.Parse(txtDuration.Text);
            _request.Title = txtMovieTitle.Text;
            _request.Year = int.Parse(txtReleaseYear.Text);
            _request.VideoLink = rtxVideoLink.Text;
            _request.Genres = movieGenreIds;*/

            MovieDto result;

            if (_id.HasValue)
            {
                result = await _screeningsApi.Update<MovieDto>(_id, _request);
            }
            else
            {
                result = await _screeningsApi.Insert<MovieDto>(_request);
            }

            await LoadReadOnly();

            if (result != null)
            {
                MessageBox.Show(Properties.Resources.Operation_Successful);
            }
            else
            {
                MessageBox.Show(Properties.Resources.Operation_BadRequest);
            }
        }   

        private void btnBack_ButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEdit_ButtonClicked(object sender, EventArgs e)
        {
            await LoadEdit();
        }

        private async void btnDelete_ButtonClicked(object sender, EventArgs e)
        {
            var result = await _screeningsApi.Delete<MovieDto>(_id);

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        #endregion
    }
}
