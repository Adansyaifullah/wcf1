using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webservice.FirstWeb;

namespace Webservice.Controllers
{
    public class HomeController : Controller
    {

        IfirstcodeClient client = new IfirstcodeClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.Message();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}