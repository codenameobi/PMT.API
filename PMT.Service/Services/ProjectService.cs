
using Microsoft.EntityFrameworkCore;
using PMT.Data;
using PMT.Data.Interfaces;
using PMT.Data.Models;

namespace PMT.Service.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Project AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public bool DeleteProject(int id)
        {
            var project = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditProject(int Id, Project project)
        {
            var projectToUpdate = _context.Projects.Find(Id);
            if (projectToUpdate != null)
            {
                projectToUpdate.Title = project.Title;
                projectToUpdate.Description = project.Description;
                projectToUpdate.CreatedAt = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Project GetProject(int id)
        {
            Project project = _context.Projects.Where(project => project.Id == id).FirstOrDefault();
            return project;
        }

        public IEnumerable<Project> GetProjects()
        {
            List<Project> projects = _context.Projects.ToList();
            return projects;
        }

    }
}
