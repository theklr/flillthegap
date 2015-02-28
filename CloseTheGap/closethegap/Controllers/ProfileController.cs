using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace closethegap.Controllers
{
    public class ProfileController : Controller
    {
        // GET: UserProfiles
       

        public ActionResult Create()
        {
            return View();
        }
    }
 
}