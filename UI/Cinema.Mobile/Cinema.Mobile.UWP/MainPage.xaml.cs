namespace Cinema.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Cinema.Mobile.App());
        }
    }
}
