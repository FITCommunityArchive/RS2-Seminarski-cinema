using Cinema.Models.ModelValidation;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.Requests.Users
{
    public class UserUpdateRequest
    {
        [MinLength(3)]
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(3)]
        public string FirstName { get; set; }
        [MinLength(3)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
    }
}
