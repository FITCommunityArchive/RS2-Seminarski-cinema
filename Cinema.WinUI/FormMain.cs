using Cinema.WinUI.Authorization;
using Cinema.WinUI.Movies;
using Cinema.WinUI.Users;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormMain : SecureBaseForm
    {
        private SecureBaseForm activeForm = null;

        private IList<string> _nextFormPrincipal;
        public FormMain(IList<string> userPrincipal) : base(new string[] { "Administrator", "Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_UserIsAllowed(object sender, EventArgs e)
        {
            btnScreenings.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnDashboard.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnMovies.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnUsers.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnLogin.Visible = false;
        }

        private void customizeDesign()
        {
            panelDashboardSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelDashboardSubmenu.Visible == true)
            {
                panelDashboardSubmenu.Visible = false;
            }
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void openChildForm(SecureBaseForm childForm)
        {
            if (activeForm != null)
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

        private void btnMovies_Click(object sender, EventArgs e)
        {
            FormMovieList frmMoviesList = new FormMovieList(_nextFormPrincipal);
            openChildForm(frmMoviesList);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin(_nextFormPrincipal);
            openChildForm(loginForm);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers(_nextFormPrincipal);
            openChildForm(formUsers);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelDashboardSubmenu);
            openChildForm(new FormDashboard(_nextFormPrincipal));
        }

        private void btnDashaboardSubmenu1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashaboardSubmenu2_Click(object sender, EventArgs e)
        {

        }
        private void btnScreenings_Click(object sender, EventArgs e)
        {
            FormScreeningList formScreeningList = new FormScreeningList(_nextFormPrincipal);
            openChildForm(formScreeningList);
        }
    }
}
