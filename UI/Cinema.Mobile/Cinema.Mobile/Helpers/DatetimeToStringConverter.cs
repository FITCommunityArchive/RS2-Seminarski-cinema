using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Cinema.Mobile.Helpers
{
    public class DatetimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var datetime = (DateTime)value;

            return datetime.ToLocalTime().ToString("g");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
