namespace Cinema.Models.Requests.Users
{
    public class UserSearchRequest : BaseSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
