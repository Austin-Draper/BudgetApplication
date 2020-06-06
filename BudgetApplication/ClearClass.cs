using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    class ClearClass
    {
        private Form1 _myForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public ClearClass(Form1 myForm, System.Windows.Forms.DataVisualization.Charting.Chart _chart)
        {
            _myForm = myForm;
            chart1 = _chart;
        }

        //clear all text boxes and the chart if there is one
        public void ClearForm()
        {
            _myForm.rentBox = "0";
            _myForm.foodBox = "0";
            _myForm.gasBox = "0";
            _myForm.healthBox = "0";
            _myForm.copayBox = "0";
            _myForm.carinsuranceBox = "0";
            _myForm.phonecontractBox = "0";
            _myForm.carannualBox = "0";
            _myForm.houseutilitiesBox = "0";
            _myForm.haircutsBox = "0";
            _myForm.miscBox = "0";
            _myForm.taxesBox = "0";
            _myForm._401kBox = "0";
            _myForm.mainincomeBox = "0";
            _myForm.extraincomeBox = "0";

            try
            {
                if (chart1.Titles.Count == 1)
                {
                    //clear the chart to default
                    chart1.Series["S1"].Points.Clear();
                    chart1.Titles.Clear();
                }
                else
                {
                    //do nothing
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong clearing the pie chart");
                //throw an exception and go back to form1 without finishing the changes
            }

        }


    }
}
