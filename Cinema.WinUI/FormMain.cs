using Cinema.Shared.Constants;
using Cinema.WinUI.Authorization;
using Cinema.WinUI.Events;
using Cinema.WinUI.Movies;
using Cinema.WinUI.News;
using Cinema.WinUI.Pricing;
using Cinema.WinUI.Reports;
using Cinema.WinUI.Screenings;
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
        public FormMain(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormDashboard formDashborad = new FormDashboard(_nextFormPrincipal);
            openChildForm(formDashborad);
        }

        private void customizeDesign()
        {
            panelReportsSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelReportsSubmenu.Visible == true)
            {
                panelReportsSubmenu.Visible = false;
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
            openChildForm(new FormDashboard(_nextFormPrincipal));
        }

        private void btnDashaboardSubmenuYearlySales_Click(object sender, EventArgs e)
        {
            FormYearlySalesReport formYearlySalesReport = new FormYearlySalesReport(_nextFormPrincipal);
            openChildForm(formYearlySalesReport);
        }

        private void btnDashaboardSubmenu2_Click(object sender, EventArgs e)
        {

        }
        private void btnScreenings_Click(object sender, EventArgs e)
        {
            FormScreeningList formScreeningList = new FormScreeningList(_nextFormPrincipal);
            openChildForm(formScreeningList);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FormReservationList formReservationList = new FormReservationList(_nextFormPrincipal);
            openChildForm(formReservationList);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelReportsSubmenu);
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            FormPricings formReports = new FormPricings(_nextFormPrincipal);
            openChildForm(formReports);
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            FormNewsList formNewsList = new FormNewsList(_nextFormPrincipal);
            openChildForm(formNewsList);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            FormEventList formEventsList = new FormEventList(_nextFormPrincipal);
            openChildForm(formEventsList);
        }
    }
}
