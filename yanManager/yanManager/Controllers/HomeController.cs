using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XireManager.Models;

namespace XireManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var siteInfo = new Websiteinfo("Demo", "RIGHT");
            ViewBag.Siteinfo = siteInfo;

            ViewData["Siteinfo"] = siteInfo;
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";

            return View(siteInfo);
        }

        private void Websiteinfo(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
