using AutoMapper;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.ViewModel;

namespace Portfolio.Settings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, ProjectViewModel>();
        }
    }
}
