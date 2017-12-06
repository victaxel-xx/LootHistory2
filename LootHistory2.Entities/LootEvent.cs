using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootHistory2.Models
{
    public class LootEvent
    {
        public int LootEventId { get; set; }
        public int CharacterId { get; set; }
        public string Player { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Item { get; set; }
        public int ItemId { get; set; }
        public string ItemString { get; set; }
        public string Response { get; set; }
        public string Votes { get; set; }
        public string Class { get; set; }
        public string Instance { get; set; }
        public string Boss { get; set; }
        public string Gear1 { get; set; }
        public string Gear2 { get; set; }
        public string ResponseId { get; set; }
        public bool IsAwardReason { get; set; }
    }
}