using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace mindnalytics
{
    class ExcelManipulator
    {
        Excel.Application excelApp = new Excel.Application();


        public bool checkOffice() 
        { 
            bool excelRunning = false;

            if(excelApp != null)
                excelRunning = true;
            else
                Console.WriteLine("Excel could not be started. Check your office instalation");

            return excelRunning;
        }

        public void guardarObjeto(ObjetoAnalisis oa)
        {
            excelApp.Visible = true;

            Excel.Workbook workBook = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet workSheet = (Excel.Worksheet) workBook.Worksheets[1];

            if(workSheet == null){
                Console.WriteLine("Worksheet could not be created.");
            }

            excelApp.Range["A1"].Value = "Nombre Experimento";
            excelApp.Range["B1"].Value = "Nombre OA";
            excelApp.Range["C1"].Value = "Path";
            excelApp.Range["D1"].Value = "QR+";
            excelApp.Range["E1"].Value = "QR-";
            excelApp.Range["F1"].Value = "QRN";
            excelApp.Range["G1"].Value = "Data";

            Excel.Range range = workSheet.get_Range("A2", "F2");

            excelApp.Range["A2"].Value = "oa.nombreExperimento";
            excelApp.Range["B2"].Value = "oa.nombreOA";
            excelApp.Range["C2"].Value = "";
            excelApp.Range["D2"].Value = "";
            excelApp.Range["E2"].Value = "";
            excelApp.Range["F2"].Value = "";
            excelApp.Range["G2"].Value = "Data";

        }
    }
}
