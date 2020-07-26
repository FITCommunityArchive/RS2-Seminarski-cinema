using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls
{
    public partial class SearchBar : UserControl
    {
        /// <summary>
        /// Event to indicate new data is available
        /// </summary>
        public event EventHandler DataAvailable;

        public SearchBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called to signal to subscribers that new data is available
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        /// <summary>
        /// Tell the parent the data is ready.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrTxtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            OnDataAvailable(null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
