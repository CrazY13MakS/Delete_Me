using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("geturl")]
        public IActionResult GetUrl()
        {
            return Ok("https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-5-preview-1/");
        }
    }
}