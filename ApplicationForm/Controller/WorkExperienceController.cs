using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationForm.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private readonly IWorkExperienceManager _manager;

        public WorkExperienceController(IWorkExperienceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkExperience>>> GetWorkExperiences()
        {
            return Ok(await _manager.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkExperience>> GetWorkExperience(int id)
        {
            var workExperience = await _manager.GetByIdAsync(id);

            if (workExperience == null)
            {
                return NotFound();
            }

            return Ok(workExperience);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkExperience(int id, WorkExperience workExperience)
        {
            if (id != workExperience.Id)
            {
                return BadRequest();
            }

            await _manager.UpdateAsync(workExperience);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkExperience(int id)
        {
            await _manager.DeleteAsync(id);
            return NoContent();
        }
    }
}
