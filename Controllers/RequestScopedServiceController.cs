using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dependency_Injection_3_Main_Methods_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestScopedServiceController : ControllerBase
    {
        private readonly IRequestScopedService _iRequestScopedService;
        public RequestScopedServiceController(IRequestScopedService iRequestScopedService)
        {
            this._iRequestScopedService = iRequestScopedService;
        }

        // GET: api/<ValuesController>
        [HttpGet("GetScopedServiceId")]
        public IActionResult GetScopedServiceId()
        {
            return Ok(this._iRequestScopedService.IRequestScopedServiceId);
        }
    }
}
