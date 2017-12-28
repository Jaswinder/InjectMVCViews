using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncludeViewsUsingJqueryAjax.Controllers
{
    public class InjectionController : Controller
    {
        // GET: Injection
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FirstChild()
        {
            return View();
        }
        public ActionResult SecondChild()
        {
            return View();
        }
        public ActionResult ThirdChild()
        {
            return View();
        }
    }
}