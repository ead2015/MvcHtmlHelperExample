using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHtmlHelperExample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Models.Student s, Models.University u)
        {

            return View("Index");
        }

        public ActionResult ActionLinkExample()
        {
           
            return View();

        }
       
    }
}
