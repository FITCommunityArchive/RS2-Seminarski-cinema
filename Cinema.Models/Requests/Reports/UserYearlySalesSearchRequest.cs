namespace Cinema.Models.Requests.Reports
{
    public class UserYearlySalesSearchRequest : BaseSearchRequest
    {
        public int? Year { get; set; }
        public int? UserId { get; set; }
        public string UserFullName { get; set; }
    }
}
