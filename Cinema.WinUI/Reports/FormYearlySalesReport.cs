using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Shared.Constants;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Models;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Reports
{
    public partial class FormYearlySalesReport : BaseDataGridForm
    {

        moduleExcel excelGenerator = new moduleExcel();
        ModulePDF pdfGenerator = new ModulePDF();
        private IList<string> _nextFormPrincipal;
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _reportsApi = new ApiService("Reports");
        private UserYearlySalesSearchRequest _request = new UserYearlySalesSearchRequest();

        public FormYearlySalesReport(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private async void FormReports_Load(object sender, EventArgs e)
        {
            _request = GetSearchRequest();
            await LoadYearlySalesReportData();
        }

        private async Task LoadYearlySalesReportData()
        {
            this.dgvUserSalesList.DoubleBuffered(true);

            string route = "user-yearly-sales";
            var yearlySales = await _reportsApi.Get<YearlySalesReportDto>(_request, route);

            var yearlySalesFlatModel = CreateFlatModel(yearlySales);

            dgvUserSalesList.AutoGenerateColumns = false;
            dgvUserSalesList.DataSource = yearlySalesFlatModel;

            AppendUserValuesToColumns(yearlySalesFlatModel);

            CreateFlatModel(yearlySales);

            dgvUserSalesList.RefreshEdit();

            pgnYearlySales.PageIndex = yearlySales.UserMonthlySales.PageIndex;
            pgnYearlySales.TotalPages = yearlySales.UserMonthlySales.TotalPages;
        }

        private UserYearlySalesSearchRequest GetSearchRequest()
        {
            UserYearlySalesSearchRequest searchRequest = new UserYearlySalesSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as UserYearlySalesSearchRequest;
            searchRequest.PageIndex = pgnYearlySales.PageIndex;
            searchRequest.UserFullName = txtCustomerName.Text;
            searchRequest.Year = DateTime.UtcNow.Year;

            if (nmrNumberOfEntries.Value > 0)
            {
                searchRequest.PageSize = (int)nmrNumberOfEntries.Value;
            }

            if (nmrYear.Value > 0)
            {
                searchRequest.Year = (int)nmrYear.Value;
            }

            if (nmrUserId.Value > 0)
            {
                searchRequest.UserId = (int)nmrUserId.Value;
            }

            return searchRequest;
        }

        private List<YearlySalesReportFlatDto> CreateFlatModel(YearlySalesReportDto yearlySales)
        {
            List<YearlySalesReportFlatDto> flatModel = yearlySales.UserMonthlySales.Data.Select(x => new YearlySalesReportFlatDto
            {
                UserId = x.UserId.ToString(),
                UserFullName = x.UserFullName,
                YearlyTotal = x.UserYearlyTotal,
                MonthlyTotals = x.UserMonthlyTotals.ToList()
            }).ToList();

            YearlySalesReportFlatDto totalRow = new YearlySalesReportFlatDto
            {
                UserId = "Total",
                YearlyTotal = yearlySales.YearlyTotalForPage,
                MonthlyTotals = yearlySales.MonthlyTotalsForPage.ToList()
            };

            flatModel.Add(totalRow);

            return flatModel;
        }

        private void AppendUserValuesToColumns(List<YearlySalesReportFlatDto> data)
        {
            for (int i = 0; i < dgvUserSalesList.Columns.Count; i++)
            {
                DataGridViewColumn column = dgvUserSalesList.Columns[i];
                int monthNumber = GetColumnMonthNumber(column);

                //check if it's a month column
                if (monthNumber > 0)
                {
                    for (int j = 0; j < dgvUserSalesList.Rows.Count; j++)
                    {
                        var row = dgvUserSalesList.Rows[j];

                        DataGridViewTextBoxCell cell = row.Cells[i] as DataGridViewTextBoxCell;

                        MonthlySaleTotalDto userMonthlyTotal = data[j].MonthlyTotals.FirstOrDefault(x => x.MonthNumber == monthNumber);

                        if (userMonthlyTotal != null)
                        {
                            cell.Value = userMonthlyTotal.Total;
                        }
                    }
                }
            }
        }

        private int GetColumnMonthNumber(DataGridViewColumn column)
        {
            if (int.TryParse(column.DataPropertyName, out int monthNumber))
            {
                return monthNumber;
            }

            return -1;
        }

        private void dgvReportReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(dgvUserSalesList, sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvUserSalesList;

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

            DataGridView dgv = dgvUserSalesList;
            pdfGenerator.ToPDF(dgv);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DataGridView dgv = dgvUserSalesList;

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

        private async void dgvUserSalesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvUserSalesList.Columns[e.ColumnIndex];

            ChangeSorting(clickedColumn.Name);

            _request = GetSearchRequest();
            _request.SortColumn = CurrentSortPropertyName;
            _request.SortOrder = CurrentSortOrder;

            await LoadYearlySalesReportData();
        }

        private async void pgnYearlySales_PageChanged(object sender, EventArgs e)
        {
            _request = GetSearchRequest();
            await LoadYearlySalesReportData();
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            _request = GetSearchRequest();
            await LoadYearlySalesReportData();
        }

        private void nmrYear_KeyDown(object sender, KeyEventArgs e)
        {
            ClearNumericUpDown(sender, e, nmrYear);
        }

        private void nmrNumberOfEntries_KeyDown(object sender, KeyEventArgs e)
        {
            ClearNumericUpDown(sender, e, nmrNumberOfEntries);
        }

        private void nmrUserId_KeyDown(object sender, KeyEventArgs e)
        {
            ClearNumericUpDown(sender, e, nmrUserId);
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
    }
}
