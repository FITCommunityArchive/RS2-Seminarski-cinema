using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Helpers
{
    public static class StringHelper
    {
        public static string LimitStringLength(this string text, int characterLimit = 50, string postfix = "...")
        {
            if (text == null || text.Length < characterLimit)
                return text;
            else
                return text.Substring(0, characterLimit - postfix.Length) + postfix;
        }
    }
}
