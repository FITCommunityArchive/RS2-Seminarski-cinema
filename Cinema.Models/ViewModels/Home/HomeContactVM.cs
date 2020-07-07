using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.ViewModels.Home
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
