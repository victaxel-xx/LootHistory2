using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LootHistory2.Models;

namespace WowApiHandler
{
    class GuildMembers
    {
        [JsonProperty("character")]
        public Character Chars { get; set; }

        public int Rank { get; set; }
    }
}
