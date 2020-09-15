using Slugify;

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

        public static string CreateSlug(this string source)
        {
            if (string.IsNullOrEmpty(source)) return null;

            SlugHelper helper = new SlugHelper();

            string slug = helper.GenerateSlug(source);
            return slug;
        }
    }
}
