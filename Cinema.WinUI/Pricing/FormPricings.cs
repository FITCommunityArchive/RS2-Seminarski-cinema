using Cinema.Models.Dtos;
using Cinema.Models.Requests.Pricing;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Pricing
{
    public partial class FormPricings : BaseDataGridForm
    {
        private ApiService _usersApi = new ApiService("Pricings");
        IList<string> _nextFormPrincipal;
        private FormPricingsDetails _frmPricingsDetails = null;
        public FormPricings(IList<string> userPrincipal) : base(new string[] { "Administrator" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void FormPricing_Load(object sender, EventArgs e)
        {
            this.dgvPricing.DoubleBuffered(true);
            PricingSearchRequest pricingSearchRequest = new PricingSearchRequest();
            pricingSearchRequest = ApplyDefaultSearchValues(pricingSearchRequest) as PricingSearchRequest;
            await LoadPricing(pricingSearchRequest);
        }

        private async Task LoadPricing(PricingSearchRequest req)
        {
            var result = await _usersApi.Get<PagedList<PricingDto>>(req);
            dgvPricing.AutoGenerateColumns = false;
            dgvPricing.DataSource = result.Data;
            pgnPricing.PageIndex = result.PageIndex;
            pgnPricing.TotalPages = result.TotalPages;

        }

        private async void pgnPricing_PageChanged(object sender, EventArgs e)
        {
            PricingSearchRequest searchRequest = GetSearchRequest();
            await LoadPricing(searchRequest);
        }

        private PricingSearchRequest GetSearchRequest()
        {
            PricingSearchRequest searchRequest = new PricingSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as PricingSearchRequest;
            searchRequest.PageIndex = pgnPricing.PageIndex;
            searchRequest.searchTerm = txtSearch.Text;

            return searchRequest;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PricingSearchRequest searchRequest = GetSearchRequest();
            await LoadPricing(searchRequest);
        }

        private void InitializeDetailsForm(int? id)
        {
            _frmPricingsDetails = new FormPricingsDetails(id);
            _frmPricingsDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDetails_Closed);
            _frmPricingsDetails.ShowDialog();
        }

        private void FormDetails_Closed(object sender, EventArgs e)
        {
            FormPricing_Load(sender, e);
        }

        private void btnAddNew_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDetailsForm(null);
        }

        private void dgvPricings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int.TryParse(clickedRow.Cells["id"].Value.ToString(), out int pricingId);

                InitializeDetailsForm(pricingId);
            }
        }
    }
}
