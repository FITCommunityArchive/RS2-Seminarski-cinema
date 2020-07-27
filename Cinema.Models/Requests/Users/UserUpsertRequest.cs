using Cinema.Models.ModelValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models.Requests.Users
{
    public class UserUpsertRequest
    {
        [Required(AllowEmptyStrings = false), MinLength(3)]
        public string UserName { get; set; }
        [Required,EmailAddress, EmailUserUnique]
        public string Email { get; set; }
        [Required,MinLength(8)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleId { get; set; }
    }
}
