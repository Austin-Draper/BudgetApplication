using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApplication
{
    class GenerateClass : Form1
    {
        int _rent, _food, _gas, _healthInsurance, _insuranceCopay, _carInsurance, _phoneContract,
                _carAnnualPay, _houseUtilities, _hairCuts, _misc, _taxes, _401k, _mainIncome, _extraIncome,
                _finalBalance;
                
        private Form1 _myForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public GenerateClass(Form1 myForm, System.Windows.Forms.DataVisualization.Charting.Chart _chart)
        {
            _myForm = myForm;
            chart1 = _chart;
        }

        public int finalBal()
        {
            _rent = Int32.Parse(_myForm.rentBox);
            _food = Int32.Parse(_myForm.foodBox);
            _gas = Int32.Parse(_myForm.gasBox);
            _healthInsurance = Int32.Parse(_myForm.healthBox);
            _insuranceCopay = Int32.Parse(_myForm.copayBox);
            _carInsurance = Int32.Parse(_myForm.carinsuranceBox);
            _phoneContract = Int32.Parse(_myForm.phonecontractBox);
            _carAnnualPay = Int32.Parse(_myForm.carannualBox);
            _houseUtilities = Int32.Parse(_myForm.houseutilitiesBox);
            _hairCuts = Int32.Parse(_myForm.haircutsBox);
            _misc = Int32.Parse(_myForm.miscBox);
            _taxes = Int32.Parse(_myForm.taxesBox);
            _401k = Int32.Parse(_myForm._401kBox);
            _mainIncome = Int32.Parse(_myForm.mainincomeBox);
            _extraIncome = Int32.Parse(_myForm.extraincomeBox);
 
            _finalBalance = ((_mainIncome + _extraIncome) - (_rent + _food + _gas + _healthInsurance + _insuranceCopay + _carInsurance
                + _phoneContract + _carAnnualPay + _houseUtilities + _hairCuts + _misc + _taxes + _401k));

            //separate into 3 sections for pie chart(housing, insurance, other)
            //housing
            int _housing = _rent + _food + _houseUtilities;
            //insurance
            int _insurance = _healthInsurance + _carInsurance + _insuranceCopay;
            //other
            int _other = _gas + _phoneContract + _carAnnualPay + _hairCuts + _misc;
            
            if (chart1.Titles.Count == 1)
            {

            }
            else
            {
                chart1.Titles.Add("Budget Chart");
                chart1.Series["S1"].IsValueShownAsLabel = true;
                chart1.Series["S1"].Points.AddXY("Housing", _housing);
                chart1.Series["S1"].Points.AddXY("Insurance", _insurance);
                chart1.Series["S1"].Points.AddXY("Other", _other);
                chart1.Series["S1"].Points.AddXY("Remaining Balance", (_mainIncome + _extraIncome) - (_other + _insurance + _housing + _taxes + _401k));
            }
            
            return _finalBalance;
        }

        public void generateExcel()
        {
            //add everything to excel spreadsheet and format spreadsheet like my example
            /*
             * 1. create workbook
             * 2. add data to excel file
             * 3. format the data properly
             * 4. save excel file to desktop
             * after this, make classes and functions for the above four steps
             */

            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = "myBudget.xlsx";
            string filepath = System.IO.Path.Combine(folderpath, filename);
            //System.Diagnostics.Process.Start(filepath);

            // 1. create workbook
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Application.Workbooks.Add();
            Excel.Worksheet sheet = workbook.Sheets.Add();
            sheet.Name = "Test";

            // 2. add data to excel file AND format the data properly
            Excel.Range chartRange;//this allows us to easily modify cells and cell ranges
            sheet.Range["A1"].Value = "PERSONAL MONTHLY BUDGET";
            chartRange = sheet.Range["A1"];
            chartRange.Font.Size = 20;
            chartRange.Font.Bold = true;
            chartRange.Font.Underline = true;

            sheet.Range["A3", "C5"].Merge(false);
            sheet.Range["A3"].Value = "PROJECTED MONTHLY INCOME";
            chartRange = sheet.Range["A3"];
            chartRange.Font.Size = 16;
            chartRange.WrapText = true;
            chartRange = sheet.Range["A3", "C5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["D3"].Value = "Main Income";
            sheet.Range["D4"].Value = "Extra Income";
            sheet.Range["D5"].Value = "Total Monthly Income";
            chartRange = sheet.Range["D3", "F5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;


            sheet.Range["G3"].Value = _mainIncome;
            sheet.Range["G4"].Value = _extraIncome;
            sheet.Range["G5"].Value = _mainIncome + _extraIncome;
            chartRange = sheet.Range["G3", "G5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlMedium;

            sheet.Range["I3", "K5"].Merge(false);
            sheet.Range["I3"].Value = "ACTUAL MONTHLY INCOME";
            chartRange = sheet.Range["I3"];
            chartRange.Font.Size = 16;
            chartRange.WrapText = true;
            chartRange = sheet.Range["I3", "K5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["L3"].Value = "Income Tax";
            sheet.Range["L4"].Value = "401k";
            sheet.Range["L5"].Value = "Total Monthly Income";
            chartRange = sheet.Range["L3", "N5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["O3"].Value = _taxes;
            sheet.Range["O4"].Value = _401k;
            sheet.Range["O5"].Value = ((_mainIncome + _extraIncome) - (_401k + _taxes));
            chartRange = sheet.Range["O3", "O5"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlMedium;

            sheet.Range["A8"].Value = "HOUSING";
            sheet.Range["A8"].Font.Size = 16;
            sheet.Range["D8"].Value = "COST";
            sheet.Range["D8"].Font.Size = 16;
            sheet.Range["A8", "D8"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            chartRange = sheet.Range["A8", "D12"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["F8"].Value = "INSURANCE";
            sheet.Range["F8"].Font.Size = 16;
            sheet.Range["I8"].Value = "COST";
            sheet.Range["I8"].Font.Size = 16;
            sheet.Range["F8", "I8"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            chartRange = sheet.Range["F8", "I12"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["A9"].Value = "Rent/Mortgage";
            sheet.Range["A10"].Value = "Utilities";
            sheet.Range["A11"].Value = "Food";
            sheet.Range["A12"].Value = "Housing Total";

            sheet.Range["D9"].Value = _rent;
            sheet.Range["D10"].Value = _houseUtilities;
            sheet.Range["D11"].Value = _food;
            sheet.Range["D12"].Value = _food + _houseUtilities + _rent;

            sheet.Range["F9"].Value = "Health Insurance";
            sheet.Range["F10"].Value = "Insurance Copay";
            sheet.Range["F11"].Value = "Car Insurance";
            sheet.Range["F12"].Value = "Insurance Total";

            sheet.Range["I9"].Value = _healthInsurance;
            sheet.Range["I10"].Value = _insuranceCopay;
            sheet.Range["I11"].Value = _carInsurance;
            sheet.Range["I12"].Value = _carInsurance + _insuranceCopay + _healthInsurance;

            sheet.Range["A14"].Value = "OTHER";
            sheet.Range["A14"].Font.Size = 16;
            sheet.Range["D14"].Value = "COST";
            sheet.Range["D14"].Font.Size = 16;
            sheet.Range["A14", "D14"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            chartRange = sheet.Range["A14", "D20"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            sheet.Range["A15"].Value = "Gas";
            sheet.Range["A16"].Value = "Phone Contract";
            sheet.Range["A17"].Value = "Car Monthly Pay";
            sheet.Range["A18"].Value = "Hair Cuts";
            sheet.Range["A19"].Value = "Misc";
            sheet.Range["A20"].Value = "Total Other";

            sheet.Range["D15"].Value = _gas;
            sheet.Range["D16"].Value = _phoneContract;
            sheet.Range["D17"].Value = _carAnnualPay;
            sheet.Range["D18"].Value = _hairCuts;
            sheet.Range["D19"].Value = _misc;
            sheet.Range["D20"].Value = _misc + _hairCuts + _carAnnualPay + _phoneContract + _gas;

            sheet.Range["A23"].Value = "FINAL BALANCE:";
            sheet.Range["A23"].Font.Size = 20;
            sheet.Range["A23"].Font.Underline = true;
            sheet.Range["D23"].Value = _finalBalance;
            sheet.Range["D23"].Font.Size = 20;
            sheet.Range["D23"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            chartRange = sheet.Range["A23", "D23"];
            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Weight = Excel.XlBorderWeight.xlThick;

            // 3. save excel file to desktop
            try
            {
                workbook.SaveAs(filepath);
            }
            catch
            {
                //need the catch if user chooses the "Don't Save" option
                //excel will ask the user where to save if this happens
            }
            finally
            {
                workbook.Close();
                excel.Quit();
            }
        }

    }
}
