using System;

namespace Cinema.Utilities.Exceptions
{
    public class NoCurrentUserFoundException : Exception
    {
        public NoCurrentUserFoundException() :
            base("Current user not found")
        { }
    }
}
