using Cinema.Models.ModelValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models.Requests.Users
{
    public class UserRegisterRequest
    {
        [Required(AllowEmptyStrings = false), MinLength(3)]
        public string UserName { get; set; }
        [Required, EmailAddress, EmailUserUnique]
        public string Email { get; set; }

        /**
         * ^: first line
            (?=.*[a-z]) : Should have at least one lower case
            (?=.*[A-Z]) : Should have at least one upper case
            (?=.*\d) : Should have at least one number
            (?=.*[#$^+=!*()@%&] ) : Should have at least one special character
            .{8,} : Minimum 8 characters
            $ : end line
         */
        [Required, RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password should have at least one lower case letter, one upper case letter, one number and one special character.")]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
    }
}
