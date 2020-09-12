using Cinema.Models.Dtos;
using Cinema.Shared.Constants;
using Cinema.WinUI.Authorization;
using Cinema.WinUI.Events;
using Cinema.WinUI.Movies;
using Cinema.WinUI.News;
using Cinema.WinUI.Pricing;
using Cinema.WinUI.Reports;
using Cinema.WinUI.Screenings;
using Cinema.WinUI.Services;
using Cinema.WinUI.Users;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormMain : SecureBaseForm
    {
        private ApiService _usersApi = new ApiService("Users");
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
            btnMovies.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnUsers.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnReports.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnPricing.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnReservations.Visible = this.ValidatedUserRoles.Contains("Administrator");
            
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            var userId = await _usersApi.GetCurrentUserId();
            var user = await _usersApi.GetById<ApplicationUserDto>(userId,null);

            FormDashboard formDashborad = new FormDashboard(_nextFormPrincipal);
            openChildForm(formDashborad);

            if(user != null) { 
                lblFullName.Text = user.FullName;
                lblWelcomeMessage.Text = "Hello " + user.FirstName;
            }
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

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FormReservationList formReservationList = new FormReservationList(_nextFormPrincipal);
            openChildForm(formReservationList);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports(_nextFormPrincipal);
            openChildForm(formReports);
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
            FormEventsList formEventsList = new FormEventsList(_nextFormPrincipal);
            openChildForm(formEventsList);
        }
    }
}
