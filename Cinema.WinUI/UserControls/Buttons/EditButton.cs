using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class EditButton : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly Color _initialButtonBackColor;
        private readonly Color _initialButtonForeColor;

        public EditButton()
        {
            InitializeComponent();
            _initialButtonBackColor = btnEdit.BackColor;
            _initialButtonForeColor = btnEdit.ForeColor;
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
            btnEdit.ChangeButtonEnabledStatus(_initialButtonBackColor, _initialButtonForeColor);
        }
    }
}
