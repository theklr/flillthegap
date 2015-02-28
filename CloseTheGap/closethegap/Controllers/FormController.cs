using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace closethegap.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Search()
        {
            // TODO: Create Partials
            return PartialView("_Search");
        }
    }
}