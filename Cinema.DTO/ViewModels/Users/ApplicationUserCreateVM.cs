using Cinema.Dto.Constants;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Dto.ViewModels.Users
{
    public class ApplicationUserCreateVM
    {
        public string Id { get; set; }

        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [RegularExpression(ValidationRegex.NAME, ErrorMessage = ValidationRegex.NAME_ERROR_MESSAGE)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [RegularExpression(ValidationRegex.NAME, ErrorMessage = ValidationRegex.NAME_ERROR_MESSAGE)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Display(Name = "Role")]
        public string RoleId { get; set; }

        public SelectList Roles { get; set; }
    }
}
