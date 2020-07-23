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
    public partial class frmMoviesList : Form
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");

        public frmMoviesList()
        {
            InitializeComponent();
        }

        private void frmMoviesList_Load(object sender, EventArgs e)
        {
            /*var result = await _moviesApi.Get<List<Model.Proizvod>>(new Movies()
            {
                VrstaId = vrstaId
            });

            grdProizvodi.DataSource = result;*/
        }

        private Task LoadMovies()
        {
            throw new NotImplementedException();
        }
    }
}
