using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace fill_in_the_gap.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
