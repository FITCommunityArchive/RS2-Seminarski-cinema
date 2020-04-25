﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.DTO.ViewModels.Events
{
    public class EventCreateVM
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
        public DateTime DateAndTime { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Promoter { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public int EventTypeId { get; set; }

        public SelectList EventTypes { get; set; }
    }
}