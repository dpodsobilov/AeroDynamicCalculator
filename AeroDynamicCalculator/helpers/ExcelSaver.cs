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
        public static string SaveToExcel(string filePath, Data data, Formulas capsule)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWB = excelApp.Workbooks.Add("");
                Excel._Worksheet excelWS = excelWB.ActiveSheet;
                excelWS.Cells[1, 1] = "R";
                excelWS.Cells[1, 2] = "rn";
                excelWS.Cells[1, 3] = "tetha";
                excelWS.Cells[1, 4] = "alpha";
                excelWS.Cells[1, 5] = "mzn";
                excelWS.Cells[1, 6] = "Cyn";
                excelWS.Cells[1, 7] = "Cx";
                excelWS.Cells[1, 8] = "Mzc";
                excelWS.Cells[1, 9] = "xD";
                excelWS.Cells[1, 10] = "cxv";
                excelWS.Cells[1, 11] = "cyv";
                excelWS.Cells[1, 12] = "cyv_alpha";

                excelWS.Cells[2, 1] = capsule.R;
                excelWS.Cells[2, 2] = capsule.Rn;
                excelWS.Cells[2, 3] = (capsule.Tetha * 180 / Math.PI);

                for (int i = 0; i < data.DictCx.Count; ++i)
                {
                    double mzn = data.DictMzn.Values.ElementAt(i);
                    double cyn = data.DictCyn.Values.ElementAt(i);
                    double cx = data.DictCx.Values.ElementAt(i);
                    double mzc = data.DictMzc.Values.ElementAt(i);
                    double xd = data.DictXD.Values.ElementAt(i);
                    double cxv = data.DictCxv.Values.ElementAt(i); 
                    double cyv = data.DictCyv.Values.ElementAt(i);
                    double cyvDer = data.DictCyvDer.Values.ElementAt(i);

                    excelWS.Cells[2 + i, 4] = i / 2.0;
                    excelWS.Cells[2 + i, 5] = Double.IsNaN(mzn) ? (double?)null : mzn;
                    excelWS.Cells[2 + i, 6] = Double.IsNaN(cyn) ? (double?)null : cyn;
                    excelWS.Cells[2 + i, 7] = Double.IsNaN(cx) ? (double?)null : cx;
                    excelWS.Cells[2 + i, 8] = Double.IsNaN(mzc) ? (double?)null : mzc;
                    excelWS.Cells[2 + i, 9] = Double.IsNaN(xd) ? (double?)null : xd;
                    excelWS.Cells[2 + i, 10] = Double.IsNaN(cxv) ? (double?)null : cxv;
                    excelWS.Cells[2 + i, 11] = Double.IsNaN(cyv) ? (double?)null : cyv;
                    excelWS.Cells[2 + i, 12] = Double.IsNaN(cyvDer) ? (double?)null : cyvDer;
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
