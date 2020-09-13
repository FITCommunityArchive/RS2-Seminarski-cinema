using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cinema.Mobile.Validators
{
    public class RegexValidator : ValidatorBase<string>
    {
        string regexPattern;

        public RegexValidator(string propertyName, Func<string> propertyValueFunc, string regexPattern, string message)
            : base(propertyName, propertyValueFunc, message)
        {
            this.regexPattern = regexPattern;
        }

        protected override bool Validate(string value)
            => Regex.IsMatch(value ?? "", regexPattern);
    }
}
