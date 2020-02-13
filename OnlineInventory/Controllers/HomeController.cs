using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineInventory.DAL;
using OnlineInventory.Entity;

namespace OnlineInventory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<User> list = Repository.GetDetails();
            ViewBag.List = list;
            TempData["List"] = list;
            ViewData["List"] = list;
            return View();
        }
    }
}