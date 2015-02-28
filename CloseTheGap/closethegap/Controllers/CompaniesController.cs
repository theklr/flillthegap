using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace closethegap.Controllers
{
    [RoutePrefix ("companies")]

    public class CompaniesController : Controller
    {
        [Route ("profile")]
        public ActionResult Profile()
        {
            return View();
        }

        [Route("create")]
        public ActionResult Create()
        {

            return View();
        }
    }
}