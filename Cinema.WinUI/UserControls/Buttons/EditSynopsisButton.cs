using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class EditSynopsisButton : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly Color _initialButtonBackColor;
        private readonly Color _initialButtonForeColor;

        public EditSynopsisButton()
        {
            InitializeComponent();
            _initialButtonBackColor = btnEditSynopsis.BackColor;
            _initialButtonForeColor = btnEditSynopsis.ForeColor;
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }

        private void EditButton_EnabledChanged(object sender, EventArgs e)
        {
            btnEditSynopsis.ChangeButtonEnabledStatus(_initialButtonBackColor, _initialButtonForeColor);
        }
    }
}
