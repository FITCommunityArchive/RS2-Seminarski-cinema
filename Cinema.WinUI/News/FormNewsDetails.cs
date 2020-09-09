using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.News;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Screenings
{
    public partial class FormNewsDetails : Form
    {
        private readonly ApiService _newsApi = new ApiService("News");
        private readonly ApiService _newsTypesApi = new ApiService("NewsTypes");
        private int? _id = null;
        private IPagedList<NewsTypeDto> _newsTypes = null;
        private NewsUpsertRequest _request = new NewsUpsertRequest();

        public event EventHandler ItemDeleted;

        public FormNewsDetails(int? id = null)
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


        private async Task LoadNewsDetails()
        {
            IncludesSearchRequest searchRequest = GetIncludes();

            var result = await _newsApi.GetById<NewsDto>(_id, searchRequest);

            LoadPropertyValues(result);
        }

        private static IncludesSearchRequest GetIncludes()
        {
            return new IncludesSearchRequest
            {
                Includes = new List<string>
                {
                    "Author", "Type"
                }
            };
        }

        private void LoadPropertyValues(NewsDto result)
        {
            LoadComboboxLists();

            txtNewsTitle.Text = result.Title;
            cmbNewsType.SelectedValue = result.TypeId;
            rtbDescription.Text = result.Description;
        }

        private void LoadComboboxLists()
        {
            cmbNewsType.DataSource = _newsTypes.Data;
            cmbNewsType.DisplayMember = nameof(NewsTypeDto.Name);
            cmbNewsType.ValueMember = nameof(NewsTypeDto.Id);
        }

        #region Event methods

        private async void frmNewsDetails_Load(object sender, EventArgs e)
        {
            _newsTypes = await _newsTypesApi.Get<PagedList<NewsTypeDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });

            if (_id.HasValue)
            {
                await LoadNewsDetails();
            }
            else
            {
                InsertNew();
            }

        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            int typeId = (int)cmbNewsType.SelectedValue;

            _request.Title = txtNewsTitle.Text;
            _request.Description = rtbDescription.Text;
            _request.TypeId = typeId;

            NewsDto result;

            if (_id.HasValue)
            {
                result = await _newsApi.Update<NewsDto>(_id, _request);
            }
            else
            {
                result = await _newsApi.Insert<NewsDto>(_request);
                _id = result.Id;
            }

            await LoadNewsDetails();

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
            var result = await _newsApi.Delete<ScreeningDto>(_id);

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        #endregion
    }
}
