using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMT.Data;
using PMT.Data.Interfaces;
using PMT.Data.Models;

namespace PMT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IProjectService _projectService;

        public ProjectController(ApplicationDbContext context, IProjectService projectService)
        {
            _context = context;
            _projectService = projectService;
        }

        [HttpPost]
        public  Project AddNewProject(Project project)
        {
            return _projectService.AddProject(project);
        }

        [HttpPut("{id}")]
        public void UpdateProject(int id, Project project)
        {
            _projectService.EditProject(id, project);
        }

        [HttpDelete("{id}")]
        public void DeleteProject(int id)
        {
            _projectService.DeleteProject(id);
        }

        [HttpGet("project/{id}")]
        public Project GetProject(int id)
        {
            return _projectService.GetProject(id);
        }

        [HttpGet("projects")]
        public IEnumerable<Project> GetAllProject()
        {
            return _projectService.GetProjects();
        }
    }
}
