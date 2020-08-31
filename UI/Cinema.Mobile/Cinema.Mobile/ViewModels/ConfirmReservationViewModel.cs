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
    public class ConfirmReservationViewModel : BaseViewModel
    {
        private readonly ApiService _reservationsApi = new ApiService("Reservations");

        public ConfirmReservationViewModel()
        {
            InitCommand = new Command(async () => await Init());
            //CheckoutReservationCommand = new Command(async () => await CheckoutReservation());
        }

        public NewReservationViewModel NewReservation { get; set; }

        public ICommand InitCommand { get; private set; }
        //public ICommand CheckoutReservationCommand { get; private set; }

        public async Task Init()
        {
        }

        public async Task<ReservationDto> CheckoutReservation()
        {
            if (NewReservation.Screening == null || NewReservation.SelectedSeats.Count == 0)
            {
                return null;
            }

            ReservationUpsertRequest request = new ReservationUpsertRequest
            {
                ScreeningId = NewReservation.Screening.Id,
                SelectedSeats = NewReservation.SelectedSeats?.Select(x => x.SeatingModel.Seat.Id).ToList()
            };

            var result = await _reservationsApi.Insert<ReservationDto>(request);

            return result;
        }
    }
}
