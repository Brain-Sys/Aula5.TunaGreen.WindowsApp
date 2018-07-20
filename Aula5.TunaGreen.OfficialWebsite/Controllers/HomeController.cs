using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula5.TunaGreen.OfficialWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
#if DEBUG
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings["MyDB"];
#endif

#if !DEBUG
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings["MyDB"];
#endif

            string str = cfg.ConnectionString;


            return View(str);
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