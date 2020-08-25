using Cinema.Models.Dtos;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MovieDetailsViewModel : BaseViewModel
    {
        public MovieDetailsViewModel()
        {

        }

        public MovieDto Movie { get; set; }
    }
}
