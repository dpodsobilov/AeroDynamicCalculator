using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroDynamicCalculator.helpers
{
    internal class CSVSaver
    {
        public static string SaveToCSV(string filePath, Data data)
        {
            try
            {
                // Write data to CSV file using CsvHelper
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField("alpha");
                    csv.WriteField("mzn");
                    csv.WriteField("Cyn");
                    csv.WriteField("Cx");
                    csv.WriteField("Mzc");
                    csv.WriteField("xD");
                    csv.WriteField("cxv");
                    csv.WriteField("cyv");
                    csv.WriteField("cyv_alpha");
                    csv.NextRecord();

                    for (int alpha = 0; alpha < 90; alpha++)
                    {
                        csv.WriteField(alpha);
                        csv.WriteField(data.DictMzn.Values.ElementAt(alpha));
                        csv.WriteField(data.DictCyn.Values.ElementAt(alpha));
                        csv.WriteField(data.DictCx.Values.ElementAt(alpha));
                        csv.WriteField(data.DictMzc.Values.ElementAt(alpha));
                        csv.WriteField(data.DictXD.Values.ElementAt(alpha));
                        csv.WriteField(data.DictCxv.Values.ElementAt(alpha));
                        csv.WriteField(data.DictCyv.Values.ElementAt(alpha));
                        csv.WriteField(data.DictCyvDer.Values.ElementAt(alpha));
                        csv.NextRecord();
                    }
                }
                return "SUCCESS";
            }
            catch(Exception ex) {
               return "Ошибка: " + ex.Message;
            }
        }
        
    }
}
