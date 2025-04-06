using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dependency_Injection_3_Main_Methods_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestSingletonServiceController : ControllerBase
    {
        private readonly IRequestSingletonService _iRequestSingletonService;
        public RequestSingletonServiceController(IRequestSingletonService iRequestSingletonService)
        {
            this._iRequestSingletonService = iRequestSingletonService;
        }

        // GET: api/<ValuesController>
        [HttpGet("GetSingletonServiceId")]
        public IActionResult GetSingletonServiceId()
        {
            return Ok(this._iRequestSingletonService.IRequestSingletonServiceId);
        }
    }
}
