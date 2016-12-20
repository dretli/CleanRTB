using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiskTableBuilderWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Returns Home Page
        public ActionResult Index()
        {
            return View();
        }
    }
}