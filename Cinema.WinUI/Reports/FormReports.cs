using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Reports
{
    public partial class FormReports : BaseDataGridForm
    {

        moduleExcel excelGenerator = new moduleExcel();
        ModulePDF pdfGenerator = new ModulePDF();
        private IList<string> _nextFormPrincipal;
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _reservationsApi = new ApiService("Reservations");
        public FormReports(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
            dgvReservationsList.Visible = false;
            pgnReservations.Visible = false;
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadScreeningsData();
            LoadReservationsData();
        }

        private async void LoadScreeningsData()
        {
            this.dgvScreeningsList.DoubleBuffered(true);
            //load screenings
            ScreeningSearchRequest searchRequest = new ScreeningSearchRequest();

            searchRequest.Includes.Add("Movie");
            searchRequest.Includes.Add("Hall");
            searchRequest.Includes.Add("Pricing");

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ScreeningSearchRequest;
            searchRequest.PageIndex = pgnScreenings.PageIndex;

            var screenings = await _screeningsApi.Get<PagedList<ScreeningDto>>(searchRequest);

            dgvScreeningsList.AutoGenerateColumns = false;
            dgvScreeningsList.DataSource = screenings.Data;
            pgnScreenings.PageIndex = screenings.PageIndex;
            pgnScreenings.TotalPages = screenings.TotalPages;
        }

        private async void LoadReservationsData()
        {
            this.dgvReservationsList.DoubleBuffered(true);
            //load reservations
            ReservationSearchRequest reservationSearchRequest = new ReservationSearchRequest();
            
            reservationSearchRequest.Includes.Add("User");
            reservationSearchRequest.Includes.Add("Invoice");
            reservationSearchRequest.Includes.Add("Screening.Movie");

            reservationSearchRequest = ApplyDefaultSearchValues(reservationSearchRequest) as ReservationSearchRequest;
            reservationSearchRequest.PageIndex = pgnReservations.PageIndex;

            var reservations = await _reservationsApi.Get<PagedList<ReservationDto>>(reservationSearchRequest);

            dgvReservationsList.AutoGenerateColumns = false;
            dgvReservationsList.DataSource = reservations.Data;
            pgnReservations.PageIndex = reservations.PageIndex;
            pgnReservations.TotalPages = reservations.TotalPages;
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvScreeningsList, sender, e);
        }

        private void dgvReportReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvReservationsList, sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgv = GetCurrentGrid();

            string title = " Excel Export by eCinema";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "eCinema.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelGenerator.ToCsV(dgv, title, sfd.FileName);
                MessageBox.Show("Finish");
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {

            DataGridView dgv = GetCurrentGrid();
            pdfGenerator.ToPDF(dgv);
        }

        private void btnLoadReservations_Click(object sender, EventArgs e)
        {
            dgvScreeningsList.Visible = false;
            pgnScreenings.Visible = false;

            dgvReservationsList.Visible = true;
            pgnReservations.Visible = true;
        }

        private void btnLoadScreenings_Click(object sender, EventArgs e)
        {
            dgvScreeningsList.Visible = true;
            pgnScreenings.Visible = true;

            dgvReservationsList.Visible = false;
            pgnReservations.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DataGridView dgv = GetCurrentGrid();

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

        private DataGridView GetCurrentGrid()
        {
            DataGridView dgv = null;
            if (dgvReservationsList.Visible == true)
            {
                dgv = dgvReservationsList;
            }
            else if (dgvScreeningsList.Visible == true)
            {
                dgv = dgvScreeningsList;
            }

            return dgv;
        }

        private void pgnScreenings_PageChanged(object sender, EventArgs e)
        {
            LoadScreeningsData();
        }

        private void pgnReservations_PageChanged(object sender, EventArgs e)
        {
            LoadReservationsData();
        }
    }
}
