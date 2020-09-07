using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class OKButton : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly Color _initialButtonBackColor;
        private readonly Color _initialButtonForeColor;

        public OKButton()
        {
            InitializeComponent();
            _initialButtonBackColor = btnOk.BackColor;
            _initialButtonForeColor = btnOk.ForeColor;
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }

        private void OKButton_EnabledChanged(object sender, EventArgs e)
        {
            btnOk.ChangeButtonEnabledStatus(_initialButtonBackColor, _initialButtonForeColor);
        }
    }
}
