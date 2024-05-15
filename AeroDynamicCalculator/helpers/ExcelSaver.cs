using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace AeroDynamicCalculator.helpers
{
    internal class ExcelSaver
    {
        public static string SaveToExcel(string filePath, Data data)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWB = excelApp.Workbooks.Add("");
                Excel._Worksheet excelWS = excelWB.ActiveSheet;
                excelWS.Cells[1, 1] = "alpha";
                excelWS.Cells[1, 2] = "mzn";
                excelWS.Cells[1, 3] = "Cyn";
                excelWS.Cells[1, 4] = "Cx";
                excelWS.Cells[1, 5] = "Mzc";
                excelWS.Cells[1, 6] = "xD";
                excelWS.Cells[1, 7] = "cxv";
                excelWS.Cells[1, 8] = "cyv";
                excelWS.Cells[1, 9] = "cyv_alpha";

                for (int alpha = 0; alpha < 90; alpha++)
                {
                    double mzn = data.DictMzn.Values.ElementAt(alpha);
                    double cyn = data.DictCyn.Values.ElementAt(alpha);
                    double cx = data.DictCx.Values.ElementAt(alpha);
                    double mzc = data.DictMzc.Values.ElementAt(alpha);
                    double xd = data.DictXD.Values.ElementAt(alpha);
                    double cxv = data.DictCxv.Values.ElementAt(alpha); 
                    double cyv = data.DictCyv.Values.ElementAt(alpha);
                    double cyvDer = data.DictCyvDer.Values.ElementAt(alpha);

                    excelWS.Cells[2 + alpha, 1] = alpha;
                    excelWS.Cells[2 + alpha, 2] = Double.IsNaN(mzn) ? (double?)null : mzn;
                    excelWS.Cells[2 + alpha, 3] = Double.IsNaN(cyn) ? (double?)null : cyn;
                    excelWS.Cells[2 + alpha, 4] = Double.IsNaN(cx) ? (double?)null : cx;
                    excelWS.Cells[2 + alpha, 5] = Double.IsNaN(mzc) ? (double?)null : mzc;
                    excelWS.Cells[2 + alpha, 6] = Double.IsNaN(xd) ? (double?)null : xd;
                    excelWS.Cells[2 + alpha, 7] = Double.IsNaN(cxv) ? (double?)null : cxv;
                    excelWS.Cells[2 + alpha, 8] = Double.IsNaN(cyv) ? (double?)null : cyv;
                    excelWS.Cells[2 + alpha, 9] = Double.IsNaN(cyvDer) ? (double?)null : cyvDer;
                }

                excelWB.SaveAs(filePath);
                excelWB.Close();
                excelApp.Quit();
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }
    }
}
