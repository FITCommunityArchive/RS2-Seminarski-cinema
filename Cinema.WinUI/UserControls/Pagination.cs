using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Shared;
using System.Windows.Forms.VisualStyles;

namespace Cinema.WinUI.UserControls
{
    public partial class Pagination : UserControl
    {
        private int _totalPages;
        private int _pageIndex;

        public int PageIndex 
        { 
            get => _pageIndex; 
            set { 
                _pageIndex = value;
                txtCurrentPage.Text = value.ToString();
            }
        }

        public int TotalPages
        {
            get => _totalPages;
            set
            {
                _totalPages = value;
                txtTotalPages.Text = value.ToString();
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
    }
}
