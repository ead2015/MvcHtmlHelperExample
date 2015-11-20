using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHtmlHelperExample.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult ValidationHelperExample()
        {

            return View();
        }

        
        [HttpPost]
        public ActionResult ValidationHelperExample(MvcHtmlHelperExample.Models.Student s)
        {
            
                if (s.Name==null)
                {
                    ModelState.AddModelError("Name", "Please provide a valid Name");
                }
           
            if (ModelState.IsValid)
            { 
            //save to database
            }
            return View();        
        }

        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Models.Student s) {

            return View("Index");
        
        }


        public ActionResult DDL()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            list.Add(new SelectListItem { Text = "Pakistan", Value = "1" });
            list.Add(new SelectListItem { Text = "India", Value = "2" });

            ViewBag.countries = list;

            return View();
        }

        [HttpPost]
        public ActionResult ddlSave()
        {
            string selectedCountryValue = Request["countries"];
            return View("ddl");

        }
    }
}
