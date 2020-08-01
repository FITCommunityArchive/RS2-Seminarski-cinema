using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls
{
    public partial class Pagination : UserControl
    {
        private int _totalPages;
        private int _pageIndex;

        public int PageIndex
        {
            get => _pageIndex;
            set
            {
                _pageIndex = value;
                btnCurrentPage.Text = value.ToString();
            }
        }

        public int TotalPages
        {
            get => _totalPages;
            set
            {
                _totalPages = value;
                btnTotalPages.Text = value.ToString();
            }
        }

        public bool HasPreviousPage
        {
            get
            {
                return (_pageIndex > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (_pageIndex < _totalPages);
            }
        }

        public event EventHandler PageChanged;

        public Pagination()
        {
            InitializeComponent();
        }

        protected virtual void OnPageChanged(EventArgs e)
        {
            PageChanged?.Invoke(this, e);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (!HasPreviousPage) return;

            _pageIndex = 1;


            OnPageChanged(EventArgs.Empty);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (!HasPreviousPage) return;

            _pageIndex--;

            OnPageChanged(EventArgs.Empty);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (!HasNextPage) return;

            _pageIndex++;

            OnPageChanged(EventArgs.Empty);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (!HasNextPage) return;

            _pageIndex = _totalPages;

            OnPageChanged(EventArgs.Empty);
        }

        private void Pagination_Load(object sender, EventArgs e)
        {
        }

        private void txtTotalPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotalPages_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrentPage_Click(object sender, EventArgs e)
        {

        }
    }
}
