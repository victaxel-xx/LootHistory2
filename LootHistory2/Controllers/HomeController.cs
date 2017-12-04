using CsvHandler;
using LootHistory2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LootHistory2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var path = @"C:\Users\victor\Desktop\csv.txt";
            CsvParser parser = new CsvParser();
            var list = parser.ParseCsv(path);
            var temp = new List<LootEventViewModel>();
            var lootList = new LootList();

            foreach (var item in list)
            {
                var loot = new LootEventViewModel()
                {
                    PlayerName = item.Player,
                    Date = item.Date,
                    Item = item.Item,
                    Boss = item.Boss,
                    IsAwardReason = item.IsAwardReason,
                    ItemId = item.ItemId,
                    Class = item.Class.ToLower(),
                    ItemUrl = "http://www.wowhead.com/item=" + item.ItemId
                };
                temp.Add(loot);
            }

            lootList.Loots = temp;

            
            return View(lootList);
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
            ViewBag.Message = "";
            var model = new Models.Guild(); 

            return View(model);
        }
        public ActionResult CharacterLoot()
        {
            ViewBag.Message = "Loot information for guild member"; //TODO dynamic name
            return View();
        }
    }
}