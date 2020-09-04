using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Models.SpecificModels;
using Cinema.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class ThankYouViewModel : BaseViewModel
    {
        public ThankYouViewModel()
        {
        }

        private string _reservationCode;
        public string ReservationCode
        {
            get { return _reservationCode; }
            set
            {
                if (_reservationCode != value)
                {
                    _reservationCode = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
