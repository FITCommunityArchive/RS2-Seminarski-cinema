using Cinema.Models.Dtos;
using Cinema.Models.Requests.Pricing;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Pricing
{
    public partial class FormPricingsDetails : Form
    {
        private readonly int? _id = null;
        private readonly PricingUpsertRequest _request = new PricingUpsertRequest();
        private ApiService _pricingsApi = new ApiService("Pricings");

        public event EventHandler ItemDeleted;

        public FormPricingsDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();

            if(!_id.HasValue)
            {
                btnDelete.Visible = false;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private async void FormPricingsDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                await LoadData();
            }
        }

        private void LoadPropertyValues(PricingDto result)
        {
            txtName.Text = result.Name;
            txtPrice.Text = result.Price.ToString();
        }

        private async Task LoadData()
        {
            var result = await _pricingsApi.GetById<PricingDto>(_id);
            LoadPropertyValues(result);
        }

        private async void btnSaveChanges_ButtonClicked(object sender, EventArgs e)
        {
            string message = "";
            if (!this.ValidateChildren())
            {
                return;
            }

            try
            {
                decimal.TryParse(txtPrice.Text, out decimal price);
                _request.Name = txtName.Text;
                _request.Price = price;

                PricingDto result;

                if (_id.HasValue)
                {
                    result = await _pricingsApi.Update<PricingDto>(_id, _request);
                    message = "Changes saved.";
                }
                else
                {
                    result = await _pricingsApi.Insert<PricingDto>(_request);
                    message = "New Pricing has been added.";
                }

                if (result != null)
                {
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_ButtonClicked(object sender, EventArgs e)
        {
            await _pricingsApi.Delete<PricingDto>(_id);
            this.Close();
        }
    }
}
