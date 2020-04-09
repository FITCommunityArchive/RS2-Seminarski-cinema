using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.DTO.ViewModels.Users
{
    public class ApplicationUserDetailsVM
    {
        public string Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Display(Name = "Email address confirmed")]
        public bool EmailConfirmed { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Role")]
        public IdentityMasterModel Role { get; set; }
    }
}
