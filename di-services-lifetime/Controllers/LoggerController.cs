using di_services_lifetime.Interface;
using Microsoft.AspNetCore.Mvc;

namespace di_services_lifetime.Controllers
{
    [ApiController]
    [Route("api/service-lifetime")]
    public class LoggerController : ControllerBase
    {
        private readonly ISystemLogging _logger;

        public LoggerController(ISystemLogging logger) => _logger = logger;

        [HttpGet("logs")]
        public async Task<IActionResult> Logs()
        {
            return Ok(new
            {
                status = _logger.GetLog()
            });
        }
    }
}
