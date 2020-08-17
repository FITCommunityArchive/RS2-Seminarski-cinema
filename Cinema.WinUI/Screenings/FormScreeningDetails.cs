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
        private int? _id = null;
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
        {
            LoadComboboxLists();
        }


        private async Task LoadScreeningDetails()
        {
            IncludesSearchRequest searchRequest = GetIncludes();

            var result = await _screeningsApi.GetById<ScreeningDto>(_id, searchRequest);

            LoadPropertyValues(result);
        }

        private static IncludesSearchRequest GetIncludes()
        {
            return new IncludesSearchRequest
            {
                Includes = new List<string>
                {
                    "Movie", "Hall", "Pricing"
                }
            };
        }

        private void LoadPropertyValues(ScreeningDto result)
        {
            LoadComboboxLists();

            dtpScreeningDate.Value = result.DateAndTime;
            cmbMovie.SelectedValue = result.Movie.Id;
            cmbHall.SelectedValue = result.Hall.Id;
            cmbPrice.SelectedValue = result.Pricing.Id;
        }

        private void LoadComboboxLists()
        {
            cmbMovie.DataSource = _movies.Data;
            cmbMovie.DisplayMember = nameof(MovieDto.Title);
            cmbMovie.ValueMember = nameof(MovieDto.Id);

            cmbHall.DataSource = _halls.Data;
            cmbHall.DisplayMember = nameof(HallDto.Name);
            cmbHall.ValueMember = nameof(HallDto.Id);

            cmbPrice.DataSource = _pricings.Data;
            cmbPrice.DisplayMember = nameof(PricingDto.Name);
            cmbPrice.ValueMember = nameof(PricingDto.Id);
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

        private async void frmScreeningDetails_Load(object sender, EventArgs e)
        {
            _movies = await _moviesApi.Get<PagedList<MovieDto>>(new MovieSearchRequest
            {
                ReturnAll = true
            });
            _halls = await _hallsApi.Get<PagedList<HallDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });
            _pricings = await _pricingsApi.Get<PagedList<PricingDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });

            if (_id.HasValue)
            {
                await LoadScreeningDetails();
            }
            else
            {
                InsertNew();
            }

        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            int movieId = (int)cmbMovie.SelectedValue;
            int hallId = (int)cmbHall.SelectedValue;
            int pricingId = (int)cmbPrice.SelectedValue;

            _request.DateAndTime = dtpScreeningDate.Value.ToUniversalTime();
            _request.MovieId = movieId;
            _request.HallId = hallId;
            _request.PricingId = pricingId;

            ScreeningDto result;

            if (_id.HasValue)
            {
                result = await _screeningsApi.Update<ScreeningDto>(_id, _request);                
            }
            else
            {
                result = await _screeningsApi.Insert<ScreeningDto>(_request);
                _id = result.Id;
            }

            await LoadScreeningDetails();

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

        private async void btnDelete_ButtonClicked(object sender, EventArgs e)
        {
            var result = await _screeningsApi.Delete<ScreeningDto>(_id);

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        #endregion

        private void dtpScreeningDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpScreeningDate.Value.ToUniversalTime() <= DateTime.UtcNow)
            {
                errorProvider1.SetError(dtpScreeningDate, Properties.Resources.Validation_FutureDateRequired);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpScreeningDate, null);
            }
        }
    }
}
