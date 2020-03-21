using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Exceptions
{
    public class DependentObjectsPresentException : Exception
    {
        public DependentObjectsPresentException() :
            base("Object cannot be deleted while depentent objects are in the database")
        { }
    }
}
