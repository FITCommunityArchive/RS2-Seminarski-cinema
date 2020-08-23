using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
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

namespace Cinema.WinUI.Reports
{
    public partial class FormReports : BaseDataGridForm
    {

        moduleExcel excelImp = new moduleExcel();
        private IList<string> _nextFormPrincipal;
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _reservationsApi = new ApiService("Reservations");
        public FormReports(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
            dgvReservationsList.Visible = false;
        }

        private async void FormReports_Load(object sender, EventArgs e)
        {
            this.dgvReportList.DoubleBuffered(true);
            this.dgvReservationsList.DoubleBuffered(true);

            //load screenings
            ScreeningSearchRequest searchRequest = new ScreeningSearchRequest();

            searchRequest.Includes.Add("Movie");
            searchRequest.Includes.Add("Hall");
            searchRequest.Includes.Add("Pricing");

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ScreeningSearchRequest;

            var screenings = await _screeningsApi.Get<PagedList<ScreeningDto>>(searchRequest);

            dgvReportList.AutoGenerateColumns = false;
            dgvReportList.DataSource = screenings.Data;
            pgnReport.PageIndex = screenings.PageIndex;
            pgnReport.TotalPages = screenings.TotalPages;


            //load reservations
            ReservationSearchRequest reservationSearchRequest = new ReservationSearchRequest();

            reservationSearchRequest.Includes.Add("User");
            reservationSearchRequest.Includes.Add("Invoice");
            reservationSearchRequest.Includes.Add("Screening.Movie");

            reservationSearchRequest = ApplyDefaultSearchValues(reservationSearchRequest) as ReservationSearchRequest;

            var reservations = await _reservationsApi.Get<PagedList<ReservationDto>>(reservationSearchRequest);

            dgvReservationsList.AutoGenerateColumns = false;
            dgvReservationsList.DataSource = reservations.Data;
            pgnReport.PageIndex = reservations.PageIndex;
            pgnReport.TotalPages = reservations.TotalPages;
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvReportList, sender, e);
        }

        private void dgvReportReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvReservationsList, sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgv = null;
            if(dgvReservationsList.Visible == true)
            {
                dgv = dgvReservationsList;
            } else if(dgvReportList.Visible == true)
            {
                dgv = dgvReportList;
            }

            string title = " Excel Export by eCinema";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "eCinema.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelImp.ToCsV(dgv, title, sfd.FileName);
                MessageBox.Show("Finish");
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            //to be added.
        }

        private void btnLoadReservations_Click(object sender, EventArgs e)
        {
            dgvReportList.Visible = false;
            dgvReservationsList.Visible = true;
        }

        private void btnLoadScreenings_Click(object sender, EventArgs e)
        {
            dgvReportList.Visible = true;
            dgvReservationsList.Visible = false;
        }
    }
}
