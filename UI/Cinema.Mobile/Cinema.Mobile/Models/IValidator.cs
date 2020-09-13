using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Mobile.Models
{
    public interface IValidator
    {
        string PropertyName { get; }
        string Message { get; }
        bool Validate();
    }
}
