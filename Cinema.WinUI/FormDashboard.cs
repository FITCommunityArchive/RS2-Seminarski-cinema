using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormDashboard : BaseDataGridForm
    {
        private IList<string> _nextFormPrincipal;

        private readonly ApiService _screeningsApi = new ApiService("Screenings");

        public FormDashboard(IList<string> userPrincipal) : base(new string[] { "Administrator", "Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private void LoadCharts()
        {
            float x1 = float.Parse("22");
            float x2 = float.Parse("33");
            float x3 = float.Parse("11");
            float x4 = float.Parse("1");
            float x5 = float.Parse("34");
            float x6 = float.Parse("14");
            float x7 = float.Parse("17");
            float x8 = float.Parse("18");
            float x9 = float.Parse("2");
            float x10 = float.Parse("40");

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 10;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Tickets");
            chart1.Series["Tickets"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["Tickets"].Color = Color.Red;

            chart1.Series["Tickets"].Points.AddXY(1, x1);
            chart1.Series["Tickets"].Points.AddXY(2, x2);
            chart1.Series["Tickets"].Points.AddXY(3, x3);
            chart1.Series["Tickets"].Points.AddXY(4, x4);
            chart1.Series["Tickets"].Points.AddXY(5, x5);
            chart1.Series["Tickets"].Points.AddXY(6, x6);
            chart1.Series["Tickets"].Points.AddXY(7, x7);
            chart1.Series["Tickets"].Points.AddXY(8, x8);
            chart1.Series["Tickets"].Points.AddXY(9, x9);
            chart1.Series["Tickets"].Points.AddXY(10, x10);



            float a1 = float.Parse("1");
            float a2 = float.Parse("22");
            float a3 = float.Parse("5");
            float a4 = float.Parse("24");
            float a5 = float.Parse("3");
            float a6 = float.Parse("30");
            float a7 = float.Parse("5");
            float a8 = float.Parse("15");
            float a9 = float.Parse("20");
            float a10 = float.Parse("12");


            chart1.Series.Add("Payments");
            chart1.Series["Payments"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Payments"].Color = Color.FromArgb(133, 195, 82);

            chart1.Series["Payments"].Points.AddXY(1, a1);
            chart1.Series["Payments"].Points.AddXY(2, a2);
            chart1.Series["Payments"].Points.AddXY(3, a3);
            chart1.Series["Payments"].Points.AddXY(4, a4);
            chart1.Series["Payments"].Points.AddXY(5, a5);
            chart1.Series["Payments"].Points.AddXY(6, a6);
            chart1.Series["Payments"].Points.AddXY(7, a7);
            chart1.Series["Payments"].Points.AddXY(8, a8);
            chart1.Series["Payments"].Points.AddXY(9, a9);
            chart1.Series["Payments"].Points.AddXY(10, a10);
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
