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
