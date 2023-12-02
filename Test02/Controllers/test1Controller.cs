using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test02.Controllers
{
    public class test1Controller : Controller
    {
        // GET: test1
        public ActionResult Show()
        {
            return File(Server.MapPath("~/Content/text.text"),"text/plain");
        }
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/test.text"), "text/plain", "MVC5.txt");
        }
        public RedirectResult ShowExternal()
        {
            return Redirect("https://google.com");
        }
    }
}