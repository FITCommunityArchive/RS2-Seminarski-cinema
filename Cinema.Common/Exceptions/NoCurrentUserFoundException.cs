using System;

namespace Cinema.Common.Exceptions
{
    public class NoCurrentUserFoundException : Exception
    {
        public NoCurrentUserFoundException() :
            base("Current user not found")
        { }
    }
}
