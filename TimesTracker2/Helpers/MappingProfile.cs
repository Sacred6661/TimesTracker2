using AutoMapper;
using TimesTracker2.Data.Enteties;
using TimesTracker2.Models;

namespace TimesTracker2.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectDto, Project>();
            CreateMap<FullProjectInfo, ProjectDto>();
            CreateMap<TimeTracker, TrackingTime>();
            CreateMap<AddTimeDto, TimeTracker>();
            CreateMap<TimeTracker, AddTimeDto>();
            CreateMap<AddProject, Project>();
        }
    }
}
