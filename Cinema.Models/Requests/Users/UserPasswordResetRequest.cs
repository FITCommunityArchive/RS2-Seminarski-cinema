namespace Cinema.Models.Requests.Users
{
    public class UserPasswordResetRequest
    {
        public string NewPassword { get; set; }
        public string Token { get; set; }
    }
}
