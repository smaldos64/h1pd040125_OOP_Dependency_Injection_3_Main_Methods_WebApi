using Microsoft.AspNetCore.Mvc;
using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;
using Dependency_Injection_3_Main_Methods_WebApi.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dependency_Injection_3_Main_Methods_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTransientServiceController : ControllerBase
    {
        private readonly IRequestTransientService _iRequestTransientService;
        public RequestTransientServiceController(IRequestTransientService iRequestTransientService)
        {
            this._iRequestTransientService = iRequestTransientService;
        }

        // GET: api/<ValuesController>
        [HttpGet("GetTransientServiceId")]
        public IActionResult GetTransientServiceId()
        {
            return Ok(this._iRequestTransientService.IRequestTransientServiceId);
        }
    }
}
