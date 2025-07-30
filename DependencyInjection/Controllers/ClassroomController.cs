using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroom _classroom;
        public ClassroomController(IClassroom classroom)
        {
            _classroom = classroom;
        }
        [HttpGet("teacher-info")]
        public IActionResult GetTeacherInfo()
        {
            var info = _classroom.GetTeacherInfo();
            return Ok(info);
        }
    }
}
