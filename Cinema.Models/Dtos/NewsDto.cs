using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos
{
    public class NewsDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int TypeId { get; set; }
        public NewsTypeDto Type { get; set; }
        public int AuthorId { get; set; }
        public ApplicationUserDto Author { get; set; }
    }
}
