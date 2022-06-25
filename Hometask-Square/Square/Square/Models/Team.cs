using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Square.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
    }
}
