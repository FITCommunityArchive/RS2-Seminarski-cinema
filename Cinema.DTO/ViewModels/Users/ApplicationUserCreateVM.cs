using Cinema.DTO.Constants;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.DTO.ViewModels.Users
{
    public class ApplicationUserCreateVM
    {
        public string Id { get; set; }

        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [RegularExpression(ValidationRegex.NAME, ErrorMessage = ValidationRegex.NAME_ERROR_MESSAGE)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [RegularExpression(ValidationRegex.NAME, ErrorMessage = ValidationRegex.NAME_ERROR_MESSAGE)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [EmailAddress]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string RoleId { get; set; }

        public SelectList Roles { get; set; }
    }
}
