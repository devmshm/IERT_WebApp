using ClsCandidate.IService;
using Microsoft.AspNetCore.Mvc;

namespace IERT_Pryag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        protected readonly IRegister _register;

        public CandidateController(IRegister register)
        {
            _register = register;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = await _register.getall();
            return Ok(user);
        }
    }
}
