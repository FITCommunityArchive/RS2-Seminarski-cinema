using Cinema.WinUI.Authorization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormDashboard : SecureBaseForm
    {
        private IList<string> _nextFormPrincipal;

        public FormDashboard(IList<string> userPrincipal) : base(new string[] {"Administrator","Content Editor"},userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
