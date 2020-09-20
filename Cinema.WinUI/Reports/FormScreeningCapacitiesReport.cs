using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Reports
{
    public partial class FormScreeningCapacitiesReport : BaseDataGridForm
    {
        ModulePDF pdfGenerator = new ModulePDF();
        private IList<string> _nextFormPrincipal;
        private bool _dateFilterCleared = true;
        private readonly ApiService _reportsApi = new ApiService("Reports");
        private ScreeningSearchRequest _request = new ScreeningSearchRequest();

        public FormScreeningCapacitiesReport(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void FormReports_Load(object sender, EventArgs e)
        {
            _request = ApplyDefaultSearchValues(_request) as ScreeningSearchRequest;
            _request.Status = TimingStatus.SCHEDULED;

            cmbStatus.DataSource = Enum.GetValues(typeof(TimingStatus));
            cmbStatus.SelectedItem = TimingStatus.SCHEDULED;

            /* The handler is added code-first in order to prevent the SearchChanged method being triggered
             * in the value initialisation for status above.*/
            cmbStatus.SelectedIndexChanged += new EventHandler(SearchChanged);

            await LoadScreeningCapacitiesData();
        }

        private async Task LoadScreeningCapacitiesData()
        {
            this.dgvScreeningCapacitiesList.DoubleBuffered(true);

            string route = "screening-capacities";
            var screeningCapacities = await _reportsApi.Get<PagedList<ScreeningCapacityDto>>(_request, route);

            dgvScreeningCapacitiesList.AutoGenerateColumns = false;
            dgvScreeningCapacitiesList.DataSource = screeningCapacities.Data;

            pgnReservations.PageIndex = screeningCapacities.PageIndex;
            pgnReservations.TotalPages = screeningCapacities.TotalPages;
        }

        private ScreeningSearchRequest GetSearchRequest()
        {
            _request = ApplyDefaultSearchValues(_request) as ScreeningSearchRequest;
            _request.PageIndex = pgnReservations.PageIndex;
            _request.SearchTerm = txtMovieTitle.Text;
            _request.Hall = txtHallName.Text;

            if (!_dateFilterCleared)
            {
                _request.Date = dtpScreeningDate.Value.ToUniversalTime();
            }
            else
            {
                _request.Date = null;
            }

            if (nmrNumberOfEntries.Value > 0)
            {
                _request.PageSize = (int)nmrNumberOfEntries.Value;
            }

            Enum.TryParse(cmbStatus.SelectedValue.ToString(), out TimingStatus timingStatus);
            _request.Status = timingStatus;

            return _request;
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvScreeningCapacitiesList, sender, e);
        }

        private void dgvReportReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvScreeningCapacitiesList, sender, e);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {

            DataGridView dgv = dgvScreeningCapacitiesList;
            pdfGenerator.ToPDF(dgv);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DataGridView dgv = dgvScreeningCapacitiesList;

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "eCinema Report";
            printer.SubTitle = "Reports on the following matter:";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "eCinema";
            printer.FooterSpacing = 15;

            printer.PrintDataGridView(dgv);
        }

        private async void dgvScreeningCapacitiesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvScreeningCapacitiesList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            _request = GetSearchRequest();
            _request.SortColumn = CurrentSortPropertyName;
            _request.SortOrder = CurrentSortOrder;

            await LoadScreeningCapacitiesData();
        }

        private async void pgnReservations_PageChanged(object sender, EventArgs e)
        {
            _request = GetSearchRequest();
            await LoadScreeningCapacitiesData();
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            _request = GetSearchRequest();
            await LoadScreeningCapacitiesData();
        }

        private void nmrNumberOfEntries_KeyDown(object sender, KeyEventArgs e)
        {
            ClearNumericUpDown(sender, e, nmrNumberOfEntries);
        }

        private void ClearNumericUpDown(object sender, KeyEventArgs e, NumericUpDown control)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                control.Value = 0;
                control.ResetText();
                SearchChanged(sender, e);
            }
        }

        private void dtpScreeningDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpScreeningDate.CustomFormat = " ";
                dtpScreeningDate.Format = DateTimePickerFormat.Custom;
                _dateFilterCleared = true;
            }

            SearchChanged(sender, e);
        }

        private void dtpScreeningDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpScreeningDate.Format == DateTimePickerFormat.Custom)
            {
                dtpScreeningDate.Format = DateTimePickerFormat.Short;
            }

            _dateFilterCleared = false;
            SearchChanged(sender, e);
        }
    }
}
