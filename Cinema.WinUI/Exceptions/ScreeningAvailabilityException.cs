using System;

namespace Cinema.WinUI.Exceptions
{
    public class CinemaArgumentOutOfRangeException : Exception
    {
        public CinemaArgumentOutOfRangeException(string message) :
            base(message)
        { }
    }
}
