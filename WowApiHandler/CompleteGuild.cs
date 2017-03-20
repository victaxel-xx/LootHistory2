using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace WowApiHandler
{
    class CompleteGuild
    {
        [JsonProperty("lastModified")]
        public Int64 LastModified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("battleGroup")]
        public string BattleGroup { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("side")]
        public int Side { get; set; }

        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        [JsonProperty("members")]
        public GuildMembers[] Members { get; set; }
    }
}
