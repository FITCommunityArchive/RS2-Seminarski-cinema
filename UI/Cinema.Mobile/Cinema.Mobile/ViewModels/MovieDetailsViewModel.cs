using Cinema.Mobile.Services;
using Cinema.Mobile.Templates;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MovieDetailsViewModel : BaseViewModel
    {

        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _reviewsApi = new ApiService("Reviews");

        public MovieDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            reviewBarCommand = new Command(onItemTapped); // this will execute on tap of image (star)
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.
        }

        public ICommand InitCommand { get; private set; }
        public ICommand reviewBarCommand { get; set; }
        public ICommand clickCommand { get; set; }
        public MovieDto Movie { get; set; }

        public int _reviewScore = 0;
        public int ReviewScore
        {
            get { return _reviewScore; }
            set { SetProperty(ref _reviewScore, value); }
        }

        public double _reviewScoreAverage;
        public double ReviewScoreAverage
        {
            get { return _reviewScoreAverage; }
            set { SetProperty(ref _reviewScoreAverage, value); }
        }

        public int _userId;
        public int UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        public bool _canVote = true;
        public bool CanVote
        {
            get { return _canVote; }
            set { SetProperty(ref _canVote, value); }
        }
        public ObservableCollection<ScreeningDto> ScreeningsList { get; set; } = new ObservableCollection<ScreeningDto>();

        public async Task Init()
        {

            ReviewScoreAverage = await _screeningsApi.GetMovieReviewScore(Movie.Id);
            ReviewScore = Convert.ToInt32(ReviewScoreAverage);
            UserId = await _screeningsApi.GetCurrentUserId();

            CanVote = await _screeningsApi.UserCanVote(UserId, Movie.Id);

            ScreeningSearchRequest screeningSearchRequest = new ScreeningSearchRequest
            {
                MovieId = Movie.Id,
                Status = TimingStatus.SCHEDULED,
                Includes = { nameof(ScreeningDto.Hall), nameof(ScreeningDto.Pricing), nameof(ScreeningDto.Movie) },
                SortColumn = nameof(ScreeningDto.DateAndTime),
                SortOrder = SortOrder.ASC
            };

            PagedList<ScreeningDto> movieScreenings = await _screeningsApi.Get<PagedList<ScreeningDto>>(screeningSearchRequest);

            ScreeningsList.Clear();

            foreach (var screening in movieScreenings.Data)
            {
                screening.DateAndTime = screening.DateAndTime.ToLocalTime();
                ScreeningsList.Add(screening);
            }
        }


        void onClicked(object obj)
        {
            ReviewBar b = (ReviewBar)obj;

            if (CanVote)
            {
                ReviewUpsertRequest review = new ReviewUpsertRequest
                {
                    Rating = ReviewScore,
                    MovieId = Movie.Id,
                    UserId = UserId,
                    Text = ""
                };
                var result = _reviewsApi.Insert<ReviewUpsertRequest>(review);
                if (result != null)
                {
                    CanVote = false;
                    App.Current.MainPage.DisplayAlert("Success", "Thank you for your vote.", "OK");
                }
            }

        }


        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChangedEvent;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }

        private void onItemTapped(object obj)
        {
            var obje = obj;
            SelectedStar = "Selected Star is " + obj;
        }
    }
}
