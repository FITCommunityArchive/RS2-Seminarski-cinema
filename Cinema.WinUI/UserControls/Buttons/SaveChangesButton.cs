using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class SaveChangesButton : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly Color _initialButtonBackColor;
        private readonly Color _initialButtonForeColor;

        public SaveChangesButton()
        {
            InitializeComponent();
            _initialButtonBackColor = btnSaveChanges.BackColor;
            _initialButtonForeColor = btnSaveChanges.ForeColor;
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }

        private void SaveChangesButton_EnabledChanged(object sender, EventArgs e)
        {
            btnSaveChanges.ChangeButtonEnabledStatus(_initialButtonBackColor, _initialButtonForeColor);
        }
    }
}
