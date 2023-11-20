using PMT.Data.Models;
using System;


namespace PMT.Data.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
    }
}
