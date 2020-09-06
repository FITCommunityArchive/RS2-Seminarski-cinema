using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Utilities.Exceptions
{
    public class EmailSendingFailedException : Exception
    {
        public EmailSendingFailedException() :
            base("Email sending failed")
        { }    
    }
}
