using Microsoft.AspNetCore.Mvc;
using Covert.Dragon.Domain.Catalog;

namespace Covert.Dragon.Api.Controllers{
    [ApiController]
    [Route("[controller]")]

    public class CatalogController: ControllerBase {
        [HttpGet]
        public IActionResult GetItems(){
            return Ok("Hello world!");
        }
    }
}