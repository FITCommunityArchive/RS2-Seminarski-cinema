using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class EditButton : UserControl
    {
        public event EventHandler ButtonClicked;

        public EditButton()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }
    }
}
