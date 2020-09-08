using System;

namespace Cinema.Utilities.Exceptions
{
    public class EmailSendingFailedException : Exception
    {
        public EmailSendingFailedException() :
            base("Email sending failed")
        { }
    }
}
