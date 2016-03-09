using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("app/index.html");
        }
    }
}
