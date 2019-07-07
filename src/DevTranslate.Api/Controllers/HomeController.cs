using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult GetHome()
        {
            return Ok();
        }
    }
}
