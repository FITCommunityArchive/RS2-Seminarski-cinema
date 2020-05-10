using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.DTO.ViewModels.Home
{
    public class HomeContactVM
    {
        [Required, StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        public string Email { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
