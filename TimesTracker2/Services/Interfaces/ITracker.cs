using AutoMapper;
using TimesTracker2.Data.Enteties;
using TimesTracker2.Models;

namespace TimesTracker2.Services.Interfaces
{
    public interface ITracker
    {
        public Task<List<ProjectDto>> GetProjects();
        public Task<ProjectDto> GetProject(int projectId);
        public TimeTracker AddTime(AddTimeDto addTime);
        public ProjectDto AddProject(AddProject project);
        public ProjectDto DeleteProject(DeleteProject project);
        public ProjectDto CompleteProject(CompleteProject project);
    }
}
