using Microsoft.AspNetCore.Mvc;
using di_services_lifetime.Services;

namespace di_services_lifetime.Controllers
{
    [ApiController]
    [Route("api/service-lifetime/resources")]
    public class ServiceLifeTimeController : ControllerBase
    {
        private readonly AccessResourceA _resourceA;
        private readonly AccessResourceB _resourceB;
        private readonly AccessResourceC _resourceC;
        
        public ServiceLifeTimeController(AccessResourceA resourceA, AccessResourceB resourceB, AccessResourceC resourceC) 
        {
            _resourceA = resourceA;
            _resourceB = resourceB;
            _resourceC = resourceC;
        }

        [HttpGet("a")]
        public async Task<IActionResult> AccessResourceA()
        {
            _resourceA.DoAnything();

            return Ok(new
            {
                status = "Resource A - Accessed"
            });
        }

        [HttpGet("b")]
        public async Task<IActionResult> AccessResourceB()
        {
            _resourceB.DoAnything();

            return Ok(new
            {
                status = "Resource B - Accessed"
            });
        }

        [HttpGet("c")]
        public async Task<IActionResult> AccessResourceC()
        {
            _resourceC.DoAnything();

            return Ok(new
            {
                status = "Resource C - Accessed"
            });
        }

        [HttpGet("ab")]
        public async Task<IActionResult> AccessResourcesAB()
        {
            _resourceA.DoAnything();
            _resourceB.DoAnything();

            return Ok(new
            {
                status = "Resources A, B - Accessed"
            });
        }

        [HttpGet("ac")]
        public async Task<IActionResult> AccessResourcesAC()
        {
            _resourceA.DoAnything();
            _resourceC.DoAnything();

            return Ok(new
            {
                status = "Resources A, C - Accessed"
            });
        }

        [HttpGet("bc")]
        public async Task<IActionResult> AccessResourcesBC()
        {
            _resourceB.DoAnything();
            _resourceC.DoAnything();

            return Ok(new
            {
                status = "Resources B, C - Accessed"
            });
        }

        [HttpGet("all")]
        public async Task<IActionResult> AccessAllResources()
        {
            _resourceA.DoAnything();
            _resourceB.DoAnything();
            _resourceC.DoAnything();

            return Ok(new
            {
                status = "Resources A, B, C - Accessed"
            });
        }
    }
}
