using System;

namespace Cinema.Utilities.Exceptions
{
    public class ScreeningAvailabilityException : Exception
    {
        public ScreeningAvailabilityException(string message) :
            base(message)
        { }
    }
}
