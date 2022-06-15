using Microsoft.Extensions.Configuration;
using Portfolio.Data;
using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
