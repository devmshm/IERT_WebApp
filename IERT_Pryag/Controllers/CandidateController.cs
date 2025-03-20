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

        [HttpGet("Get_Basic")]
        public async Task<IActionResult> Get(string appid)
        {
            var user = await _register.getall(appid);
            return Ok(user);
        }

        [HttpGet("Get_Personal")]
        public async Task<IActionResult> Getpersonal(string appid)
        {
            var user = await _register.Get_Personal(appid);
            return Ok(user);
        }

        [HttpGet("Get_Address")]
        public async Task<IActionResult> Getadd(string appid)
        {
            var user = await _register.getadd(appid);
            return Ok(user);
        }

        [HttpPost("Add_Basic")]
        public async Task<IActionResult> Post([FromBody] Basic_details basic)
        {
            var response = await _register.InsertBasic(basic);
            return StatusCode(response.Status, response);
        }
    }
}