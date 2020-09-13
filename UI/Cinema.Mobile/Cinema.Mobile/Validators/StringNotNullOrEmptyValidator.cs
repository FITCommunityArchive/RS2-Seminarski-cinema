using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Mobile.Validators
{
    public class StringNotNullOrEmptyValidator : ValidatorBase<string>
    {
        public StringNotNullOrEmptyValidator(string propertyName, Func<string> propertyValueFunc, string message)
            : base(propertyName, propertyValueFunc, message)
        { }

        protected override bool Validate(string value)
         => !string.IsNullOrEmpty(value);
    }
}
