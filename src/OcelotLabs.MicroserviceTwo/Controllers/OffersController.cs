using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OcelotLabs.MicroserviceTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "offer1", "offer2" };
        }
    }
}
