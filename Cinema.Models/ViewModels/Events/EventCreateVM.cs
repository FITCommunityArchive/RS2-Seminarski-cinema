using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.ViewModels.Events
{
    public class EventCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [MinLength(5)]
        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public DateTime DateAndTime { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Promoter { get; set; }

        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public int EventTypeId { get; set; }

        public SelectList EventTypes { get; set; }

    }
}
