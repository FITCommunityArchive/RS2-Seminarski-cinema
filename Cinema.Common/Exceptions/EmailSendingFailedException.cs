using System;

namespace Cinema.Common.Exceptions
{
    public class EmailSendingFailedException : Exception
    {
        public EmailSendingFailedException() :
            base("Email sending failed")
        { }
    }
}
