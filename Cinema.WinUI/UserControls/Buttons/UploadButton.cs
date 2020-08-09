using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class UploadButton : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly Color _initialButtonBackColor;
        private readonly Color _initialButtonForeColor;

        public UploadButton()
        {
            InitializeComponent();
            _initialButtonBackColor = btnUpload.BackColor;
            _initialButtonForeColor = btnUpload.ForeColor;
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }

        private void UploadButton_EnabledChanged(object sender, EventArgs e)
        {
            btnUpload.ChangeButtonEnabledStatus(_initialButtonBackColor, _initialButtonForeColor);
        }
    }
}
