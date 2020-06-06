using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApplication
{
    public partial class Form1 : Form
    {
        public string rentBox
        {
            get { return rentTextBox.Text; }
            set { rentTextBox.Text = value; }
        }
        public string foodBox
        {
            get { return foodTextBox.Text; }
            set { foodTextBox.Text = value; }
        }
        public string gasBox
        {
            get { return gasTextBox.Text; }
            set { gasTextBox.Text = value; }
        }
        public string healthBox
        {
            get { return healthinsuranceTextBox.Text; }
            set { healthinsuranceTextBox.Text = value; }
        }
        public string copayBox
        {
            get { return insurancecopayTextBox.Text; }
            set { insurancecopayTextBox.Text = value; }
        }
        public string carinsuranceBox
        {
            get { return carinsuranceTextBox.Text; }
            set { carinsuranceTextBox.Text = value; }
        }
        public string phonecontractBox
        {
            get { return phonecontractTextBox.Text; }
            set { phonecontractTextBox.Text = value; }
        }
        public string carannualBox
        {
            get { return carannualpayTextBox.Text; }
            set { carannualpayTextBox.Text = value; }
        }
        public string houseutilitiesBox
        {
            get { return houseutilitiesTextBox.Text; }
            set { houseutilitiesTextBox.Text = value; }
        }
        public string haircutsBox
        {
            get { return haircutsTextBox.Text; }
            set { haircutsTextBox.Text = value; }
        }
        public string miscBox
        {
            get { return miscTextBox.Text; }
            set { miscTextBox.Text = value; }
        }
        public string taxesBox
        {
            get { return taxesTextBox.Text; }
            set { taxesTextBox.Text = value; }
        }
        public string _401kBox
        {
            get { return _401kTextBox.Text; }
            set { _401kTextBox.Text = value; }
        }
        public string mainincomeBox
        {
            get { return mainIncomeTextBox.Text; }
            set { mainIncomeTextBox.Text = value; }
        }
        public string extraincomeBox
        {
            get { return extraIncomeTextBox.Text; }
            set { extraIncomeTextBox.Text = value; }
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //call function to calculate final balance
            int _finalBalance;
            GenerateClass a = new GenerateClass(this, chart1);
            _finalBalance = a.finalBal();
            a.generateExcel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearClass a = new ClearClass(this, chart1);
            a.ClearForm();//clears all textboxes in the form AND the chart

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //open the excel document the user asks for, extract the data and fill the textboxes with the data
            //make each number a single line calling from class
            LoadClass _load = new LoadClass(this, chart1);
            _load.LoadForm();
            
        }
    }
}
