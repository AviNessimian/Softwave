using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softwave.Web.Models;

namespace Softwave.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AggregateController : Controller
    {

        [HttpGet]
        [Authorize(Policy = "ReadScope")]
        public IActionResult Get()
        {
            var dto = AggregateRoot.DataSeed();

            return Ok(dto);
        }
    }
}
