using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OcelotLabs.MicroserviceOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "product1", "product2" };
        }
    }
}
