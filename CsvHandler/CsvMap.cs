using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootHistory2.Models;
using CsvHelper.Configuration;
using System.Globalization;

namespace CsvHandler
{
    public class CsvMap
    {
        public sealed class LootEventMap : CsvClassMap<LootEvent>
        {
            public LootEventMap()
            {
                Map(m => m.Player).Name("player");
                Map(m => m.Date).Name("date");
                Map(m => m.Time).Name("time");
                Map(m => m.Item).Name("item");
                Map(m => m.ItemId).Name("itemID");
                Map(m => m.ItemString).Name("itemString");
                Map(m => m.Response).Name("response");
                Map(m => m.Votes).Name("votes");
                Map(m => m.Class).Name("class");
                Map(m => m.Instance).Name("instance");
                Map(m => m.Boss).Name("boss");
                Map(m => m.Gear1).Name("gear1");
                Map(m => m.Gear2).Name("gear2");
                Map(m => m.ResponseId).Name("responseID");
                Map(m => m.IsAwardReason).Name("isAwardReason");
            }
        }
    }
}
