using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationForm.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationManager _manager;

        public EducationController(IEducationManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationDetails>>> GetEducationDetails()
        {
            return Ok(await _manager.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EducationDetails>> GetEducationDetails(int id)
        {
            var educationDetails = await _manager.GetByIdAsync(id);

            if (educationDetails == null)
            {
                return NotFound();
            }

            return Ok(educationDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationDetails(int id, EducationDetails educationDetails)
        {
            if (id != educationDetails.Id)
            {
                return BadRequest();
            }

            await _manager.UpdateAsync(educationDetails);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducationDetails(int id)
        {
            await _manager.DeleteAsync(id);
            return NoContent();
        }
    }
}
