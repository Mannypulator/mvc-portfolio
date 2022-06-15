using Microsoft.Extensions.Configuration;
using Portfolio.Data;
using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Services
{
    public class ProjectService : IProjectService
    {
        public List<Project> Projects { get; set; }
        private readonly IConfiguration _config;


        public ProjectService(IConfiguration config)
        {
            Projects = Seeder.Reader(config);
            _config = config;

        }
    }
}
