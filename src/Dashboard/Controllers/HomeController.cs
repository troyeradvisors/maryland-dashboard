using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("{*catchall}")]
        public IActionResult Index()
        {
            return View("~/wwwroot/index.cshtml");
        }
    }
}
