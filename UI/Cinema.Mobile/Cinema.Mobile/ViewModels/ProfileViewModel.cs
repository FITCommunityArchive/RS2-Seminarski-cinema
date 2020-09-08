using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {

        protected readonly ApiService _usersApi = new ApiService("Users");
        public ProfileViewModel()
        {
            SaveCommand = new Command(async () => await SaveChanges());
            InitCommand = new Command(async () => await Init());
        }

        public ICommand SaveCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ApplicationUserDto _currentUser;
        public ApplicationUserDto CurrentUser
        {
            get { return _currentUser; }
            set { SetProperty(ref _currentUser, value); }
        }
        public int UserId { get; set; }

        public async Task Init()
        {
            UserId = await _usersApi.GetCurrentUserId();
            CurrentUser = await _usersApi.GetById<ApplicationUserDto>(UserId);
        }

        public async Task SaveChanges()
        {
            IsBusy = true;
            UserUpdateRequest request = new UserUpdateRequest()
            {
                FirstName = CurrentUser.FirstName,
                LastName = CurrentUser.LastName,
                PhoneNumber = CurrentUser.PhoneNumber,
                Email = CurrentUser.Email,
                UserName = CurrentUser.UserName,
                RoleId = CurrentUser.UserRoles[0].RoleId
            };
            var result = await _usersApi.Update<ApplicationUserDto>(UserId, request);
            if (result != null)
            {
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Success", "Your changes have been saved.", "Ok");
            }
        }
    }
}
