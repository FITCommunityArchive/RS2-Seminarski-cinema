namespace Cinema.Dto.Constants
{
    public static class ValidationRegex
    {
        public const string NAME = "[A-Za-zČčĆćŽžŠšĐđ - ']*";
        public const string NAME_ERROR_MESSAGE = "Names can only contain letters, spaces, or charcters - and '!";
    }
}
