using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowApiHandler
{
    public static class ClassColors
    {
        public static Dictionary<int, string> CColors { get; set; }
        static ClassColors()
        {
            CColors = SetClassColors();
        }

        private static Dictionary<int, string> SetClassColors()
        {
            Dictionary<int, string> colors = new Dictionary<int, string>();
            colors.Add(1, "warrior");
            colors.Add(2, "paladin");
            colors.Add(3, "hunter");
            colors.Add(4, "rogue");
            colors.Add(5, "priest");
            colors.Add(6, "dk");
            colors.Add(7, "shaman");
            colors.Add(8, "mage");
            colors.Add(9, "warlock");
            colors.Add(10, "monk");
            colors.Add(11, "druid");
            colors.Add(12, "dh");

            return colors;
        }
    }
}
