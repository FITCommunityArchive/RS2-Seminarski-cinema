namespace Cinema.Services.Constants
{
    public static class ValidationMessages
    {
        public const string DATE_NOT_FUTURE = "The date and time of the new Screening must be in the future.";
        public const string HALL_ALREADY_OCCUPIED = "There is already a Screening set in the selected Hall for the selected period.";
        public const string NO_SEATS_SELECTED = "You must select at least one seat.";
        public const string INTERNAL_SERVER_ERROR = "Internal Server Error.";
        public const string PRICE_INVALID = "Price amount is not valid.";
        public const string ALL_FIELDS_REQUIRED = "All fields are required.";
    }
}
