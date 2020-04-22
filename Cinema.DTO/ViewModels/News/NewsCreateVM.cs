﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.DTO.ViewModels.News
{
    public class NewsCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public string AuthorId { get; set; }


        [Required(ErrorMessage = "The field is required!")]
        public int NewsTypeId { get; set; }

        public SelectList NewsTypes { get; set; }
    }
}
