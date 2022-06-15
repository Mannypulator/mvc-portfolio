using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Services;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.ViewModel;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProjectService _projectServices;
        private readonly IMapper _mapper;

        public HomeController(IProjectService projectService, IMapper mapper)
        {
            _projectServices = projectService;
            _mapper = mapper;

        }

        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public IActionResult Projects()
        {
            var projects = _projectServices.Projects;
            var projectToList = _mapper.Map<List<ProjectViewModel>>(projects);
            return View(projectToList);
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
