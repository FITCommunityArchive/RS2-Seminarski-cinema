using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormDashboard : BaseDataGridForm
    {
        private IList<string> _nextFormPrincipal;

        private readonly ApiService _reportsApi = new ApiService("Reports");
        private readonly ApiService _screeningsApi = new ApiService("Screenings");

        public FormDashboard(IList<string> userPrincipal) : base(new string[] { "Administrator", "Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void LoadCharts()
        {
            UserYearlySalesSearchRequest searchRequest = new UserYearlySalesSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as UserYearlySalesSearchRequest;
            searchRequest.PageSize = int.MaxValue;
            searchRequest.ReturnAll = true;
            searchRequest.Year = DateTime.UtcNow.Year;

            string route = "user-yearly-sales";
            var yearlySales = await _reportsApi.Get<YearlySalesReportDto>(searchRequest, route);

            lblMainChartName.Text = $"Ticketing data for the year {searchRequest.Year}";

            List<float> monthlyTotals = new List<float>();

            foreach (var monthlyTotal in yearlySales.MonthlyTotalsForPage)
            {
                monthlyTotals.Add((float)monthlyTotal.Total);
            }

            var chart = crtSalesPerMonth.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            double maximumY = (double)yearlySales.MonthlyTotalsForPage.Max(x => x.Total) + 1000;
            double intervalY = 1000;

            if (maximumY > 5000)
            {
                intervalY = 2500;
            }

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = maximumY;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = intervalY;

            string label = "Sales (without VAT)";
            crtSalesPerMonth.Series.Add(label);
            crtSalesPerMonth.Series[label].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            crtSalesPerMonth.Series[label].Color = Color.Red;

            for (int i = 0; i < monthlyTotals.Count; i++)
            {
                crtSalesPerMonth.Series[label].Points.AddXY(i + 1, monthlyTotals[i]);
            }

            await LoadWidgets(yearlySales);
        }

        private async Task LoadWidgets(YearlySalesReportDto yearlySales)
        {
            string route = "dashboard-widgets";
            var dashboardWidgets = await _reportsApi.Get<DashboardWidgetsDto>(null, route);

            string currency = Currencies.DEFAULT;

            lblCustomersCounter.Text = dashboardWidgets.CustomersCount.ToString();
            lblTicketsCounter.Text = dashboardWidgets.TicketsSold.ToString();
            lblIncomeAmount.Text = $"{((int)yearlySales.YearlyTotalForPage).ToString()} {currency}";
            lblCapacityCount.Text = dashboardWidgets.TotalSeatCapacities.ToString();
            lblOccupiedCount.Text = dashboardWidgets.TotalSeatsOccupied.ToString();
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadCharts();

            this.dgvScreenings.DoubleBuffered(true);
            ScreeningSearchRequest searchRequest = new ScreeningSearchRequest();

            searchRequest.Includes.Add("Movie");
            searchRequest.Includes.Add("Hall");
            searchRequest.Includes.Add("Pricing");

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ScreeningSearchRequest;

            var screenings = await _screeningsApi.Get<PagedList<ScreeningDto>>(searchRequest);

            dgvScreenings.AutoGenerateColumns = false;
            dgvScreenings.DataSource = screenings.Data;
            pgnScreenings.PageIndex = screenings.PageIndex;
            pgnScreenings.TotalPages = screenings.TotalPages;

        }

        private void tlpWidget_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                if (e.Column == 0 || e.Column == 1 || e.Column == 2)
                {
                    e.Graphics.DrawLine(Pens.LightGray, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
                    e.Graphics.DrawLine(Pens.LightGray, new Point(e.CellBounds.Left, e.CellBounds.Bottom),
                        new Point(e.CellBounds.Right, e.CellBounds.Bottom));
                }
            }
            else if (e.Row == tlpWidget.RowCount - 1)
            {
                if (e.Column == 0 || e.Column == 1 || e.Column == 2)
                {
                    e.Graphics.DrawLine(Pens.LightGray, new Point(e.CellBounds.Left, e.CellBounds.Bottom),
                        new Point(e.CellBounds.Right, e.CellBounds.Bottom));
                }
            }

        }

        private void dgvScreenings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvScreenings, sender, e);
        }
    }
}
