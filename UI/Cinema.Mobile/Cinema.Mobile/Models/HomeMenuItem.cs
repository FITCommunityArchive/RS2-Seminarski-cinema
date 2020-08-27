using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        NowShowing,
        GridDemo,
        LogOut
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
