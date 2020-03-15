using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Github.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Este es el Controller Index!
            //Comentario agregado por Gerard R. Vizcaino
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