using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 畢業專題練習.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Receive()
        {
            ViewBag.Message = "接案人畫面.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "發案人畫面.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "註冊.";

            return View();
        }

        public ActionResult Sign()
        {
            ViewBag.Message = "登入.";

            return View();
        }

    }
}