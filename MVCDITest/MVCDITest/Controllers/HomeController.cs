using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace MVCDITest.Controllers
{
    using System;

    public class HomeController : Controller
    {
        [Dependency]
        public ITestDIService Service { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Service.Build(DateTime.Now);
            ViewBag.Message = Service.GetMessageAbout();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Service.GetMessgaeContact();

            return View();
        }
    }
}