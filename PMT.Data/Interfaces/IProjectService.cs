using PMT.Data.Models;
using System;


namespace PMT.Data.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
        Project AddProject(Project project);
        bool EditProject(int Id, Project project);
        bool DeleteProject(int id);
        Project GetProject(int id);
    }
}
