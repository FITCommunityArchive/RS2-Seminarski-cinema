using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls
{
    public partial class ExtendedButton : Button
    {
        public ExtendedButton()
        {
            InitializeComponent();
        }

        public ExtendedButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ChangeButtonEnabledStatus(Color backColor, Color foreColor)
        {
            if (this.Enabled)
            {
                this.BackColor = backColor;
                this.ForeColor = foreColor;
            }
            else
            {
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Gray;
            }
        }
    }
}
