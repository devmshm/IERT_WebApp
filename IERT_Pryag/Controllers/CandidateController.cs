using ClsCandidate.Service;
using ClsData.Models;
using Microsoft.AspNetCore.Mvc;

namespace IERT_Pryag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        protected readonly Register _register;
        public CandidateController(Register register)
        {
            _register = register;
        }

        [HttpGet("Get Basic")]
        public async Task<IActionResult> Get()
        {
            var user = await _register.getall();
            return Ok(user);
        }

        [HttpGet("Get Address")]
        public async Task<IActionResult> Getadd()
        {
            var user = await _register.getadd();
            return Ok(user);
        }

        [HttpPost("Add Basic")]
        public async Task<IActionResult> Post([FromBody] Basic_details basic)
        {
            var response = await _register.InsertBasic(basic);
            return StatusCode(response.Status, response);
        }
    }
}