using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LootHistory2.Models
{
    public class Character
    {
        public List<LootEvent> LootEvents { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Realm { get; set; }
        public string Battlegroup { get; set; }
        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public string Thumbnail { get; set; }
        public string Guild { get; set; }
        public string GuildRealm { get; set; }
        public int LastModified { get; set; }
    }
}