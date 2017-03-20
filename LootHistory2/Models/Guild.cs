using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootHistory2.Models
{
    public class Guild
    {
        public List<Character> Characters { get; set; }
        public Guild()
        {
            Characters = WowApiHandler.GuildHandler.GetRoster();
        }
    }
}