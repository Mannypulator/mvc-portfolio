
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Portfolio.Models;
using System.Collections.Generic;
using System.IO;

namespace Portfolio.Data
{
    public class Seeder
    {
        public Seeder()
        {

        }
        public static List<Project> Reader(IConfiguration config)
        {
            var data = File.ReadAllText(config.GetSection("DummyFilePath:Path").Value);

            var projects = JsonConvert.DeserializeObject<List<Project>>(data);
            return projects;

        }
    }
}
