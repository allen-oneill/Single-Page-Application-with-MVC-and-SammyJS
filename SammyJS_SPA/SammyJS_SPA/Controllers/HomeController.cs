using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SammyJS_SPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult spa_1()
        {
            return View();
        }

        public ActionResult spa_2()
        {
            return View();
        }

        public ActionResult LoadDivFromRemote()
        {
            ViewBag.Title = "Remotly injected!";
            ViewBag.Message = "This div was remotly injected into the dom from the server at: " + DateTime.Now.ToLongTimeString();
            return PartialView("~/Views/Home/RemoteDiv.cshtml"); // we only want the view html, not a template wrapper, therefore return PartialView(), not View()
        }

    }
}