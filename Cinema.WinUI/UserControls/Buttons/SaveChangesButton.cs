using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class SaveChangesButton : UserControl
    {
        public event EventHandler ButtonClicked;

        public SaveChangesButton()
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
