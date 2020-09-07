using Cinema.Models.Dtos;
using Cinema.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class FormMovieSynopsis : Form
    {
        public event EventHandler<ParameterEventArgs> SynopsisAdded;

        public FormMovieSynopsis(MovieDto movie)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(movie.Synopsis))
            {
                rtbSynopsisText.Text = movie.Synopsis;
            }

            lblMovieSynopsisTitle.Text = movie.Title;
        }

        public void OnSynopsisAdded(EventArgs e)
        {
            SynopsisAdded?.Invoke(this, new ParameterEventArgs(rtbSynopsisText.Text));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OnSynopsisAdded(e);
            this.Close();
        }
    }
}
