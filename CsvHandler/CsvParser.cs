using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootHistory2.Models;
using CsvHelper;
using CsvHelper.TypeConversion;
using System.IO;
using System.Diagnostics;

namespace CsvHandler
{
    class CsvParser
    {
        public List<LootEvent> ParseCsv(string url)
        {
            List<LootEvent> data = null;

            try
            {
                CsvReader csv = new CsvReader(File.OpenText(url));
                csv.Configuration.RegisterClassMap<CsvMap.LootEventMap>();
                csv.Configuration.TrimFields = true;
                csv.Configuration.IgnoreHeaderWhiteSpace = true;
                data = csv.GetRecords<LootEvent>().ToList();
            }
            catch (CsvTypeConverterException e)
            {
                Debug.Write(e.Data.Values);
            }
            return data;
        }
    }
}
