namespace Cinema.Mobile.Models
{
    public enum MenuItemType
    {
        NowShowing,
        MyReservations,
        News,
        Events,
        Profile,
        LogOut
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
