using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class DeleteButton : UserControl
    {
        public event EventHandler ButtonClicked;

        public DeleteButton()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }
    }
}
