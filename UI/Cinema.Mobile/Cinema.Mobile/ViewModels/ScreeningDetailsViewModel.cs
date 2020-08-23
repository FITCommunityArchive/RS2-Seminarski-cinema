using Cinema.Models.Dtos;

namespace Cinema.Mobile.ViewModels
{
    public class ScreeningDetailsViewModel : BaseViewModel
    {
        public ScreeningDetailsViewModel()
        {
        }

        public ScreeningDto Screening { get; set; }
    }
}
