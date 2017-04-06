using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LootHistory2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Guild()
        {
            ViewBag.Message = "Memebers who hold the ranks 'Freakin Baws', 'Officer' and 'Member'";
            var model = new Models.Guild(); 

            return View(model);
        }
        public ActionResult CharacterLoot()
        {
            ViewBag.Message = "Loot information for guild member"; //TODO dynamic name
            var model = new Models.CharacterLoot();

            return View();
        }
    }
}