using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace closethegap.Controllers
{
    [RoutePrefix("file")]

    public class FileManagerController : Controller
    {
        
        [Route("images")]
        public ActionResult ImageGrid()
        {
            return View();
        }

        [Route("imageUpload")]
        public ActionResult ImageUpload()
        {
            return View();
        }
    }
}