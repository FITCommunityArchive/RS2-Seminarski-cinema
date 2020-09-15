using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.News;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
        private NewsDto _news = null;
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

            _news = await _newsApi.GetById<NewsDto>(_id, searchRequest);

            LoadPropertyValues(_news);
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

            if (result.Image != null && result.Image.Length > 0)
            {
                picImage.Image = result.Image.ToImage();
            }
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
                _request.AuthorId = _news.AuthorId;
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
            var result = await _newsApi.Delete<NewsDto>(_id);

            OnItemDeleted(EventArgs.Empty);
            this.Close();
        }

        private void btnUpload_ButtonClicked(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                _request.Image = file;

                Image image = Image.FromFile(fileName);
                picImage.Image = image;
            }
        }

        private void txtNewsTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtNewsTitle, e);
        }

        private void cmbNewsType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbNewsType.SelectedValue == null)
            {
                errorProvider1.SetError(cmbNewsType, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbNewsType, null);
            }
        }

        private void rtbDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(rtbDescription, e);
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

        #endregion
    }
}
