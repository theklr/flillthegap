using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace closethegap.Controllers
{

        [RoutePrefix("user")]


    public class RegistrationController : Controller
    {

        [Route("registration")]
        public ActionResult Registration()
        {
            return View();
        }

    }
}