using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootHistory2.Models
{
    public class LootEventViewModel
    {
        public string PlayerName { get; set; }
        public string Date { get; set; }
        public string Item { get; set; }
        public int ItemId { get; set; }
        public bool IsAwardReason { get; set; }
        public string Boss { get; set; }
        public string Class { get; set; }
        public string ItemUrl { get; set; }
    }
}