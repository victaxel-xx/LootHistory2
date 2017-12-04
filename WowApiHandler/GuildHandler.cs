using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootHistory2.Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace WowApiHandler
{
    public class GuildHandler
    {
        private const string APIKEY = "93czppz2vrr48y4teztzgjv35dtffbyw";
        private static string GuildName = "Untamed";
        private static string Realm = "Kazzak";

        public static List<Character> GetRoster()
        {
            string result = string.Empty;
            var url = "https://eu.api.battle.net/wow/guild/" + Realm + "/" + GuildName + "?fields=members&locale=en_GB&apikey=" + APIKEY;
            List<Character> chars = new List<Character>();
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("https://eu.api.battle.net/wow/guild/");
                HttpResponseMessage response = client.GetAsync(Realm + "/" + GuildName + "?fields=members&locale=en_GB&apikey=" + APIKEY).Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsStringAsync().Result;
            }

            //The complete json structure
            CompleteGuild comp = JsonConvert.DeserializeObject<CompleteGuild>(result);
            List<Character> onlyChars = new List<Character>();
            foreach (var item in comp.Members)
            {
                if (item.Rank == 2 || item.Rank == 3 || item.Rank == 0)
                {
                    if (item.Chars.Level == 110)
                    {
                        onlyChars.Add(item.Chars);
                    }
                }
            }
            return onlyChars;
        }
    }
}
