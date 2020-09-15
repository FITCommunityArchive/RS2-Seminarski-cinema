using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.Events;
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

namespace Cinema.WinUI.Events
{
    public partial class FormEventDetails : Form
    {
        private readonly ApiService _eventsApi = new ApiService("Events");
        private readonly ApiService _eventTypesApi = new ApiService("EventTypes");
        private int? _id = null;
        private IPagedList<EventTypeDto> _eventTypes = null;
        private EventDto _event = null;
        private EventUpsertRequest _request = new EventUpsertRequest();

        public event EventHandler ItemDeleted;

        public FormEventDetails(int? id = null)
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

        private async Task LoadEventDetails()
        {
            IncludesSearchRequest searchRequest = GetIncludes();

            _event = await _eventsApi.GetById<EventDto>(_id, searchRequest);

            LoadPropertyValues(_event);
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

        private void LoadPropertyValues(EventDto result)
        {
            LoadComboboxLists();

            txtEventTitle.Text = result.Title;
            cmbEventType.SelectedValue = result.TypeId;
            rtbDescription.Text = result.Description;
            txtPromoter.Text = result.Promoter;
            dtpEventDate.Value = result.DateAndTime.ToLocalTime();
            dtpEventTime.Value = result.DateAndTime.ToLocalTime();

            if (result.Image != null && result.Image.Length > 0)
            {
                picImage.Image = result.Image.ToImage();
            }
        }

        private void LoadComboboxLists()
        {
            cmbEventType.DataSource = _eventTypes.Data;
            cmbEventType.DisplayMember = nameof(EventTypeDto.Name);
            cmbEventType.ValueMember = nameof(EventTypeDto.Id);
        }

        private DateTime GetEventUtcDateAndTime()
        {
            DateTime dateTime = dtpEventDate.Value.Date + dtpEventTime.Value.TimeOfDay;
            return dateTime.ToUniversalTime();
        }

        #region Event methods

        private async void frmEventDetails_Load(object sender, EventArgs e)
        {
            _eventTypes = await _eventTypesApi.Get<PagedList<EventTypeDto>>(new BaseSearchRequest
            {
                ReturnAll = true
            });

            if (_id.HasValue)
            {
                await LoadEventDetails();
            }
            else
            {
                InsertNew();
            }

        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            int typeId = (int)cmbEventType.SelectedValue;
            DateTime dateTime = GetEventUtcDateAndTime();

            _request.Title = txtEventTitle.Text;
            _request.Description = rtbDescription.Text;
            _request.TypeId = typeId;
            _request.Promoter = txtPromoter.Text;
            _request.DateAndTime = dateTime;

            EventDto result;

            if (_id.HasValue)
            {
                _request.AuthorId = _event.AuthorId;
                result = await _eventsApi.Update<EventDto>(_id, _request);
            }
            else
            {
                result = await _eventsApi.Insert<EventDto>(_request);
                _id = result.Id;
            }

            await LoadEventDetails();

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
            var result = await _eventsApi.Delete<EventDto>(_id);

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

        private void dtpEventDateAndTime_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateTime = GetEventUtcDateAndTime();

            if (dateTime <= DateTime.UtcNow.AddDays(-1))
            {
                errorProvider1.SetError(dtpEventDate, Properties.Resources.Validation_FutureDateRequired);
                errorProvider1.SetError(dtpEventTime, Properties.Resources.Validation_FutureDateRequired);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpEventDate, null);
                errorProvider1.SetError(dtpEventTime, null);
            }
        }

        private void txtEventTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyField(txtEventTitle, e);
        }

        private void rtbDescription_Validating(object sender, CancelEventArgs e)
        {

            ValidateEmptyField(rtbDescription, e);
        }

        private void cmbEventType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbEventType.SelectedValue == null)
            {
                errorProvider1.SetError(cmbEventType, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbEventType, null);
            }
        }

        #endregion
    }
}
