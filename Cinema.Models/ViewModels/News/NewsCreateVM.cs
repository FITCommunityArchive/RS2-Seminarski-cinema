using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.ViewModels.News
{
    public class NewsCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [MinLength(5)]
        [MaxLength(5000)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public int NewsTypeId { get; set; }

        public SelectList NewsTypes { get; set; }
    }
}
