using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApplication
{
    class LoadClass
    {

        private Form1 _myForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public LoadClass(Form1 myForm, System.Windows.Forms.DataVisualization.Charting.Chart _chart)
        {
            _myForm = myForm;
            chart1 = _chart;
        }

        public void LoadForm()
        {
            //1. get file path with OpenFileDialog
            OpenFileDialog excelDialog = new OpenFileDialog();
            excelDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            string path = "";
            if (excelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = excelDialog.FileName;
                path = strfilename;
                MessageBox.Show(strfilename);//xlsx... re-use my old open file code using this file path
            }


            //2. open selected excel file

            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(path);//open selected excel file

            //3. refill all textboxes with correct data
            ClearClass a = new ClearClass(_myForm, chart1);
            a.ClearForm();//clears all textboxes in the form AND the chart (want to clear before adding data incase user had some data added already)

            Excel.Worksheet sheet = workbook.Sheets["Test"];//select the "Test" worksheet from excel file
            //Excel.Range chartRange;//this allows us to easily modify cells and cell ranges
            //string _mainIncome = sheet.Range["G3"].Value;
            _myForm.mainincomeBox = sheet.Range["G3"].Value.ToString();
            _myForm.extraincomeBox = sheet.Range["G4"].Value.ToString();
            _myForm.taxesBox = sheet.Range["O3"].Value.ToString();
            _myForm._401kBox = sheet.Range["O4"].Value.ToString();
            _myForm.rentBox = sheet.Range["D9"].Value.ToString();
            _myForm.houseutilitiesBox = sheet.Range["D10"].Value.ToString();
            _myForm.foodBox = sheet.Range["D11"].Value.ToString();
            _myForm.healthBox = sheet.Range["I9"].Value.ToString();
            _myForm.copayBox = sheet.Range["I10"].Value.ToString();
            _myForm.carinsuranceBox = sheet.Range["I11"].Value.ToString();
            _myForm.gasBox = sheet.Range["D15"].Value.ToString();
            _myForm.phonecontractBox = sheet.Range["D16"].Value.ToString();
            _myForm.carannualBox = sheet.Range["D17"].Value.ToString();
            _myForm.haircutsBox = sheet.Range["D18"].Value.ToString();
            _myForm.miscBox = sheet.Range["D19"].Value.ToString();

            workbook.Close();
            excel.Quit();

            //4. create the pie chart with textbox data
            GenerateClass genClass = new GenerateClass(_myForm, chart1);
            int _finalBal = genClass.finalBal();

        }


    }
}
