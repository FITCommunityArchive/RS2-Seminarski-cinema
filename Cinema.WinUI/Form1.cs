using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }


        private void customizeDesign()
        {
            panelDashboardSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(panelDashboardSubmenu.Visible == true)
            {
                panelDashboardSubmenu.Visible = false;
            }
        }

        private void ShowSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            } else
            {
                submenu.Visible = false;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelDashboardSubmenu);
            openChildForm(new FormDashboard());
        }

        private void buttonDashaboardSubmenu1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashaboardSubmenu2_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
