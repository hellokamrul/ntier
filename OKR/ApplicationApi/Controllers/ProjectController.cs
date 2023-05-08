using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Interfaces;
using DAL.DTO;


namespace ApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProject _iproject;
        public ProjectController(IProject project)
        {
            _iproject = project;
        }
        [HttpPost]
        public IActionResult CreateProject(ProjectDTO obj)
        {
            return Ok(_iproject.CreateProject(obj));
        }
    }
}
