using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class AddNewButton : UserControl
    {
        public event EventHandler ButtonClicked;

        public AddNewButton()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }
    }
}
