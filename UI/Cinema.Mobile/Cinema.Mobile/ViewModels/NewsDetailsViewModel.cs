using Cinema.Models.Dtos;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NewsDetailsViewModel : BaseViewModel
    {
        public NewsDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public NewsDto Article { get; set; }

        public async Task Init()
        {
            await Task.CompletedTask;
        }

    }
}
