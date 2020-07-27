using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models.ModelValidation
{
    public class EmailUserUniqueAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            /**
             * How to handle calling of context in Cinema.Models?
             */
            //var _context = (AppDbContext)validationContext.GetService(typeof(AppDbContext));
            //var entity = _context.Users.FirstOrDefault(e => e.Email == value.ToString());

            var email = "boris.h@aquila-ars.com";

            if (email.Contains(value.ToString()))
            {
                return new ValidationResult(GetErrorMessage(value.ToString()));
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage(string email)
        {
            return $"Email {email} is already in use.";
        }
    }
}
