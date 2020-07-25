using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
