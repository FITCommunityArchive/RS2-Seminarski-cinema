using System;

namespace Cinema.Common.Exceptions
{
    public class ScreeningAvailabilityException : Exception
    {
        public ScreeningAvailabilityException(string message) :
            base(message)
        { }
    }
}
