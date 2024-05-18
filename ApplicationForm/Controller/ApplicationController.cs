using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationForm.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IAplicationManager _manager;

        public ApplicationController(IAplicationManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicDetails>>> GetBasicDetails()
        {
            return Ok(await _manager.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BasicDetails>> GetBasicDetails(int id)
        {
            var basicDetails = await _manager.GetByIdAsync(id);

            if (basicDetails == null)
            {
                return NotFound();
            }

            return Ok(basicDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasicDetails(int id, BasicDetails basicDetails)
        {
            if (id != basicDetails.Id)
            {
                return BadRequest();
            }

            await _manager.UpdateAsync(basicDetails);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasicDetails(int id)
        {
            await _manager.DeleteAsync(id);
            return NoContent();
        }

    }
}
