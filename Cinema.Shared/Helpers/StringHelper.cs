namespace Cinema.Shared.Helpers
{
    public static class StringHelper
    {
        public static string Truncate(this string text, int characterLimit = 50, string postfix = "...")
        {
            if (text == null || text.Length < characterLimit)
                return text;
            else
                return text.Substring(0, characterLimit - postfix.Length) + postfix;
        }
    }
}
