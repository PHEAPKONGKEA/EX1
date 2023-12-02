using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Show you home Page";
            return View();
        }
        public ActionResult ShowMoreDetail()
        {
            return View("~/Views/About/Index.cshtml");     
        }
        public int add()
        {
            int a = 3;
            int b = 4;
            int s = a + b;
            return s;
        }
        public ActionResult Show()
        {
            return File(Server.MapPath("~/Content/test.text"), "text/plain");
        }
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/test.text"), "text/plain", "MVC5.txt");
        }
    }
}