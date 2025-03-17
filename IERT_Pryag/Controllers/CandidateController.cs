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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = await _register.getall();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Basic_details basic)
        {
            var response = await _register.InsertBasic(basic);
            return StatusCode(response.Status, response);

        }
    }
}