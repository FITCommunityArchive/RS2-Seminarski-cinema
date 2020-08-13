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

namespace Cinema.WinUI.Movies
{
    public partial class FormMovieDetails : Form
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private readonly ApiService _genresApi = new ApiService("Genres");
        private readonly int? _id = null;
        private bool _isReadonly = true;
        private MovieUpsertRequest _request = new MovieUpsertRequest();
        private IPagedList<GenreDto> _genres = null;
        public Process videoLinkProcess;

        public event EventHandler ItemDeleted;

        public FormMovieDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        protected virtual void OnItemDeleted(EventArgs e)
        {
            ItemDeleted?.Invoke(this, e);
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            _genres = await _genresApi.Get<PagedList<GenreDto>>(null);

            if (_id.HasValue)
            {
                await LoadReadOnly();
            }
            else
            {
                InsertNew();
            }

        }

        private void InsertNew()
        {
            chlGenres.DataSource = _genres.Data;
            chlGenres.DisplayMember = nameof(GenreDto.Name);

            SetReadonly(false);
        }


        private async Task LoadReadOnly()
        {
            var result = await _moviesApi.GetById<MovieDto>(_id);

            SetReadonly(true);

            LoadPropertyValues(result);

            List<GenreDto> movieGenres = _genres.Data.Where(x => result.GenreMovies.Select(y => y.GenreId).Contains(x.Id)).ToList();

            lbxGenres.DataSource = movieGenres;
            lbxGenres.DisplayMember = nameof(GenreDto.Name);
        }

        private async Task LoadEdit()
        {
            var resultGenres = await _genresApi.Get<PagedList<GenreDto>>(null);
            var result = await _moviesApi.GetById<MovieDto>(_id);

            SetReadonly(false);

            LoadPropertyValues(result);

            List<GenreDto> movieGenres = resultGenres.Data.Where(x => result.GenreMovies.Select(y => y.GenreId).Contains(x.Id)).ToList();

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

        private void LoadPropertyValues(MovieDto result)
        {
            txtMovieTitle.Text = result.Title;
            txtReleaseYear.Text = result.Year.ToString();
            txtCountry.Text = result.Country;
            txtDirectors.Text = result.Directors;
            txtWriters.Text = result.Writers;
            txtActors.Text = result.Actors;
            txtDuration.Text = result.Duration.ToString();
            rtxVideoLink.Text = result.VideoLink;

            if (result.Poster != null && result.Poster.Length > 0)
            {
                picPoster.Image = result.Poster.ToImage();
            }
        }

        private void SetGenresListReadonly(bool isReadonly)
        {
            lbxGenres.Visible = isReadonly;
            chlGenres.Visible = !isReadonly;
        }

        private void SetReadonly(bool isReadonly)
        {
            _isReadonly = isReadonly;

            btnSaveChanges.Enabled = !isReadonly;
            btnUploadPoster.Enabled = !isReadonly;
            btnEdit.Enabled = isReadonly;

            txtMovieTitle.ReadOnly = _isReadonly;
            txtReleaseYear.ReadOnly = _isReadonly;
            txtCountry.ReadOnly = _isReadonly;
            txtDirectors.ReadOnly = _isReadonly;
            txtActors.ReadOnly = _isReadonly;
            txtDuration.ReadOnly = _isReadonly;
            txtWriters.ReadOnly = _isReadonly;
            rtxVideoLink.ReadOnly = _isReadonly;

            SetGenresListReadonly(isReadonly);
        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            List<int> movieGenreIds = chlGenres.CheckedItems.Cast<GenreDto>().Select(x => x.Id).ToList();

            _request.Actors = txtActors.Text;
            _request.Country = txtCountry.Text;
            _request.Directors = txtDirectors.Text;
            _request.Writers = txtWriters.Text;
            _request.Duration = int.Parse(txtDuration.Text);
            _request.Title = txtMovieTitle.Text;
            _request.Year = int.Parse(txtReleaseYear.Text);
            _request.VideoLink = rtxVideoLink.Text;
            _request.Genres = movieGenreIds;

            MovieDto result;

            if (_id.HasValue)
            {
                result = await _moviesApi.Update<MovieDto>(_id, _request);
            }
            else
            {
                result = await _moviesApi.Insert<MovieDto>(_request);
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

        private void ValidateEmptyField(Control control, CancelEventArgs e)
        {
            if (_isReadonly) return;

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
            if (_isReadonly) return;

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

        private void txtReleaseYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateInteger(txtReleaseYear, e);
        }

        private void txtMovieTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtMovieTitle, e);
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            ValidateInteger(txtDuration, e);
        }

        private void txtCountry_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtCountry, e);
        }

        private void txtDirectors_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtDirectors, e);
        }

        private void txtActors_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtActors, e);
        }

        private void txtWriters_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtWriters, e);
        }

        private void btnUploadPoster_ButtonClicked(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                _request.Poster = file;

                Image image = Image.FromFile(fileName);
                picPoster.Image = image;
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
            var result = await _moviesApi.Delete<MovieDto>(_id);

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        private void rtxVideoLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            videoLinkProcess = new Process();
            videoLinkProcess = Process.Start(e.LinkText);
        }
    }
}
