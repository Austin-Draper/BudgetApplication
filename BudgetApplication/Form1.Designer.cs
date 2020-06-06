namespace BudgetApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extraIncomeTextBox = new System.Windows.Forms.TextBox();
            this.mainIncomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._401kTextBox = new System.Windows.Forms.TextBox();
            this._401kLabel = new System.Windows.Forms.Label();
            this.miscTextBox = new System.Windows.Forms.TextBox();
            this.haircutsTextBox = new System.Windows.Forms.TextBox();
            this.houseutilitiesTextBox = new System.Windows.Forms.TextBox();
            this.carannualpayTextBox = new System.Windows.Forms.TextBox();
            this.phonecontractTextBox = new System.Windows.Forms.TextBox();
            this.carinsuranceTextBox = new System.Windows.Forms.TextBox();
            this.insurancecopayTextBox = new System.Windows.Forms.TextBox();
            this.taxesTextBox = new System.Windows.Forms.TextBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.haircutsLabel = new System.Windows.Forms.Label();
            this.houseutilitiesLabel = new System.Windows.Forms.Label();
            this.carannualpayLabel = new System.Windows.Forms.Label();
            this.phonecontractLabel = new System.Windows.Forms.Label();
            this.carinsuranceLabel = new System.Windows.Forms.Label();
            this.insurancecopayLabel = new System.Windows.Forms.Label();
            this.healthinsuranceTextBox = new System.Windows.Forms.TextBox();
            this.healthinsuranceLabel = new System.Windows.Forms.Label();
            this.taxesLabel = new System.Windows.Forms.Label();
            this.gasTextBox = new System.Windows.Forms.TextBox();
            this.gasLabel = new System.Windows.Forms.Label();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.rentLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.51067F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(250, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 437);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.extraIncomeTextBox);
            this.panel1.Controls.Add(this.mainIncomeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._401kTextBox);
            this.panel1.Controls.Add(this._401kLabel);
            this.panel1.Controls.Add(this.miscTextBox);
            this.panel1.Controls.Add(this.haircutsTextBox);
            this.panel1.Controls.Add(this.houseutilitiesTextBox);
            this.panel1.Controls.Add(this.carannualpayTextBox);
            this.panel1.Controls.Add(this.phonecontractTextBox);
            this.panel1.Controls.Add(this.carinsuranceTextBox);
            this.panel1.Controls.Add(this.insurancecopayTextBox);
            this.panel1.Controls.Add(this.taxesTextBox);
            this.panel1.Controls.Add(this.miscLabel);
            this.panel1.Controls.Add(this.haircutsLabel);
            this.panel1.Controls.Add(this.houseutilitiesLabel);
            this.panel1.Controls.Add(this.carannualpayLabel);
            this.panel1.Controls.Add(this.phonecontractLabel);
            this.panel1.Controls.Add(this.carinsuranceLabel);
            this.panel1.Controls.Add(this.insurancecopayLabel);
            this.panel1.Controls.Add(this.healthinsuranceTextBox);
            this.panel1.Controls.Add(this.healthinsuranceLabel);
            this.panel1.Controls.Add(this.taxesLabel);
            this.panel1.Controls.Add(this.gasTextBox);
            this.panel1.Controls.Add(this.gasLabel);
            this.panel1.Controls.Add(this.foodTextBox);
            this.panel1.Controls.Add(this.foodLabel);
            this.panel1.Controls.Add(this.rentTextBox);
            this.panel1.Controls.Add(this.rentLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 437);
            this.panel1.TabIndex = 0;
            // 
            // extraIncomeTextBox
            // 
            this.extraIncomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extraIncomeTextBox.Location = new System.Drawing.Point(97, 570);
            this.extraIncomeTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.extraIncomeTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.extraIncomeTextBox.Name = "extraIncomeTextBox";
            this.extraIncomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.extraIncomeTextBox.TabIndex = 15;
            this.extraIncomeTextBox.Text = "0";
            // 
            // mainIncomeTextBox
            // 
            this.mainIncomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainIncomeTextBox.Location = new System.Drawing.Point(97, 530);
            this.mainIncomeTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.mainIncomeTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.mainIncomeTextBox.Name = "mainIncomeTextBox";
            this.mainIncomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.mainIncomeTextBox.TabIndex = 14;
            this.mainIncomeTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Extra Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Main Income";
            // 
            // _401kTextBox
            // 
            this._401kTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._401kTextBox.Location = new System.Drawing.Point(97, 490);
            this._401kTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this._401kTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this._401kTextBox.Name = "_401kTextBox";
            this._401kTextBox.Size = new System.Drawing.Size(121, 20);
            this._401kTextBox.TabIndex = 13;
            this._401kTextBox.Text = "0";
            // 
            // _401kLabel
            // 
            this._401kLabel.AutoSize = true;
            this._401kLabel.Location = new System.Drawing.Point(7, 490);
            this._401kLabel.Name = "_401kLabel";
            this._401kLabel.Size = new System.Drawing.Size(32, 13);
            this._401kLabel.TabIndex = 25;
            this._401kLabel.Text = "401K";
            // 
            // miscTextBox
            // 
            this.miscTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscTextBox.Location = new System.Drawing.Point(97, 410);
            this.miscTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.miscTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.miscTextBox.Name = "miscTextBox";
            this.miscTextBox.Size = new System.Drawing.Size(121, 20);
            this.miscTextBox.TabIndex = 11;
            this.miscTextBox.Text = "0";
            // 
            // haircutsTextBox
            // 
            this.haircutsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.haircutsTextBox.Location = new System.Drawing.Point(97, 370);
            this.haircutsTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.haircutsTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.haircutsTextBox.Name = "haircutsTextBox";
            this.haircutsTextBox.Size = new System.Drawing.Size(121, 20);
            this.haircutsTextBox.TabIndex = 10;
            this.haircutsTextBox.Text = "0";
            // 
            // houseutilitiesTextBox
            // 
            this.houseutilitiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.houseutilitiesTextBox.Location = new System.Drawing.Point(97, 330);
            this.houseutilitiesTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.houseutilitiesTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.houseutilitiesTextBox.Name = "houseutilitiesTextBox";
            this.houseutilitiesTextBox.Size = new System.Drawing.Size(121, 20);
            this.houseutilitiesTextBox.TabIndex = 9;
            this.houseutilitiesTextBox.Text = "0";
            // 
            // carannualpayTextBox
            // 
            this.carannualpayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carannualpayTextBox.Location = new System.Drawing.Point(97, 290);
            this.carannualpayTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.carannualpayTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.carannualpayTextBox.Name = "carannualpayTextBox";
            this.carannualpayTextBox.Size = new System.Drawing.Size(121, 20);
            this.carannualpayTextBox.TabIndex = 8;
            this.carannualpayTextBox.Text = "0";
            // 
            // phonecontractTextBox
            // 
            this.phonecontractTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonecontractTextBox.Location = new System.Drawing.Point(97, 250);
            this.phonecontractTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.phonecontractTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.phonecontractTextBox.Name = "phonecontractTextBox";
            this.phonecontractTextBox.Size = new System.Drawing.Size(121, 20);
            this.phonecontractTextBox.TabIndex = 7;
            this.phonecontractTextBox.Text = "0";
            // 
            // carinsuranceTextBox
            // 
            this.carinsuranceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carinsuranceTextBox.Location = new System.Drawing.Point(97, 210);
            this.carinsuranceTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.carinsuranceTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.carinsuranceTextBox.Name = "carinsuranceTextBox";
            this.carinsuranceTextBox.Size = new System.Drawing.Size(121, 20);
            this.carinsuranceTextBox.TabIndex = 6;
            this.carinsuranceTextBox.Text = "0";
            // 
            // insurancecopayTextBox
            // 
            this.insurancecopayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insurancecopayTextBox.Location = new System.Drawing.Point(97, 170);
            this.insurancecopayTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.insurancecopayTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.insurancecopayTextBox.Name = "insurancecopayTextBox";
            this.insurancecopayTextBox.Size = new System.Drawing.Size(121, 20);
            this.insurancecopayTextBox.TabIndex = 5;
            this.insurancecopayTextBox.Text = "0";
            // 
            // taxesTextBox
            // 
            this.taxesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxesTextBox.Location = new System.Drawing.Point(97, 450);
            this.taxesTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.taxesTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.taxesTextBox.Name = "taxesTextBox";
            this.taxesTextBox.Size = new System.Drawing.Size(121, 20);
            this.taxesTextBox.TabIndex = 12;
            this.taxesTextBox.Text = "0";
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(7, 410);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(74, 13);
            this.miscLabel.TabIndex = 16;
            this.miscLabel.Text = "Miscellaneous";
            // 
            // haircutsLabel
            // 
            this.haircutsLabel.AutoSize = true;
            this.haircutsLabel.Location = new System.Drawing.Point(7, 370);
            this.haircutsLabel.Name = "haircutsLabel";
            this.haircutsLabel.Size = new System.Drawing.Size(50, 13);
            this.haircutsLabel.TabIndex = 15;
            this.haircutsLabel.Text = "Hair Cuts";
            // 
            // houseutilitiesLabel
            // 
            this.houseutilitiesLabel.AutoSize = true;
            this.houseutilitiesLabel.Location = new System.Drawing.Point(7, 330);
            this.houseutilitiesLabel.Name = "houseutilitiesLabel";
            this.houseutilitiesLabel.Size = new System.Drawing.Size(74, 13);
            this.houseutilitiesLabel.TabIndex = 14;
            this.houseutilitiesLabel.Text = "House Utilities";
            // 
            // carannualpayLabel
            // 
            this.carannualpayLabel.AutoSize = true;
            this.carannualpayLabel.Location = new System.Drawing.Point(7, 290);
            this.carannualpayLabel.Name = "carannualpayLabel";
            this.carannualpayLabel.Size = new System.Drawing.Size(84, 13);
            this.carannualpayLabel.TabIndex = 13;
            this.carannualpayLabel.Text = "Car Monthly Pay";
            // 
            // phonecontractLabel
            // 
            this.phonecontractLabel.AutoSize = true;
            this.phonecontractLabel.Location = new System.Drawing.Point(7, 250);
            this.phonecontractLabel.Name = "phonecontractLabel";
            this.phonecontractLabel.Size = new System.Drawing.Size(81, 13);
            this.phonecontractLabel.TabIndex = 12;
            this.phonecontractLabel.Text = "Phone Contract";
            // 
            // carinsuranceLabel
            // 
            this.carinsuranceLabel.AutoSize = true;
            this.carinsuranceLabel.Location = new System.Drawing.Point(7, 210);
            this.carinsuranceLabel.Name = "carinsuranceLabel";
            this.carinsuranceLabel.Size = new System.Drawing.Size(73, 13);
            this.carinsuranceLabel.TabIndex = 11;
            this.carinsuranceLabel.Text = "Car Insurance";
            // 
            // insurancecopayLabel
            // 
            this.insurancecopayLabel.AutoSize = true;
            this.insurancecopayLabel.Location = new System.Drawing.Point(7, 170);
            this.insurancecopayLabel.Name = "insurancecopayLabel";
            this.insurancecopayLabel.Size = new System.Drawing.Size(87, 13);
            this.insurancecopayLabel.TabIndex = 10;
            this.insurancecopayLabel.Text = "Insurance Copay";
            // 
            // healthinsuranceTextBox
            // 
            this.healthinsuranceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthinsuranceTextBox.Location = new System.Drawing.Point(97, 130);
            this.healthinsuranceTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.healthinsuranceTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.healthinsuranceTextBox.Name = "healthinsuranceTextBox";
            this.healthinsuranceTextBox.Size = new System.Drawing.Size(121, 20);
            this.healthinsuranceTextBox.TabIndex = 4;
            this.healthinsuranceTextBox.Text = "0";
            // 
            // healthinsuranceLabel
            // 
            this.healthinsuranceLabel.AutoSize = true;
            this.healthinsuranceLabel.Location = new System.Drawing.Point(7, 130);
            this.healthinsuranceLabel.Name = "healthinsuranceLabel";
            this.healthinsuranceLabel.Size = new System.Drawing.Size(88, 13);
            this.healthinsuranceLabel.TabIndex = 8;
            this.healthinsuranceLabel.Text = "Health Insurance";
            // 
            // taxesLabel
            // 
            this.taxesLabel.AutoSize = true;
            this.taxesLabel.Location = new System.Drawing.Point(7, 450);
            this.taxesLabel.Name = "taxesLabel";
            this.taxesLabel.Size = new System.Drawing.Size(63, 13);
            this.taxesLabel.TabIndex = 6;
            this.taxesLabel.Text = "Income Tax";
            // 
            // gasTextBox
            // 
            this.gasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gasTextBox.Location = new System.Drawing.Point(97, 90);
            this.gasTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.gasTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.gasTextBox.Name = "gasTextBox";
            this.gasTextBox.Size = new System.Drawing.Size(121, 20);
            this.gasTextBox.TabIndex = 3;
            this.gasTextBox.Text = "0";
            // 
            // gasLabel
            // 
            this.gasLabel.AutoSize = true;
            this.gasLabel.Location = new System.Drawing.Point(7, 90);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(26, 13);
            this.gasLabel.TabIndex = 4;
            this.gasLabel.Text = "Gas";
            // 
            // foodTextBox
            // 
            this.foodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodTextBox.Location = new System.Drawing.Point(97, 50);
            this.foodTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.foodTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(121, 20);
            this.foodTextBox.TabIndex = 2;
            this.foodTextBox.Text = "0";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(7, 50);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(31, 13);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "Food";
            // 
            // rentTextBox
            // 
            this.rentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentTextBox.Location = new System.Drawing.Point(97, 10);
            this.rentTextBox.MaximumSize = new System.Drawing.Size(200, 20);
            this.rentTextBox.MinimumSize = new System.Drawing.Size(121, 20);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(121, 20);
            this.rentTextBox.TabIndex = 1;
            this.rentTextBox.Text = "0";
            // 
            // rentLabel
            // 
            this.rentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentLabel.AutoSize = true;
            this.rentLabel.Location = new System.Drawing.Point(7, 10);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(63, 13);
            this.rentLabel.TabIndex = 0;
            this.rentLabel.Text = "Rent/Home";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.generateButton);
            this.flowLayoutPanel1.Controls.Add(this.loadButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 452);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(3, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(110, 36);
            this.generateButton.TabIndex = 16;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.AutoSize = true;
            this.loadButton.Location = new System.Drawing.Point(119, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(110, 36);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 44);
            this.panel2.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 36);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(447, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 36);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gasTextBox;
        private System.Windows.Forms.Label gasLabel;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label taxesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label haircutsLabel;
        private System.Windows.Forms.Label houseutilitiesLabel;
        private System.Windows.Forms.Label carannualpayLabel;
        private System.Windows.Forms.Label phonecontractLabel;
        private System.Windows.Forms.Label carinsuranceLabel;
        private System.Windows.Forms.Label insurancecopayLabel;
        private System.Windows.Forms.TextBox healthinsuranceTextBox;
        private System.Windows.Forms.Label healthinsuranceLabel;
        private System.Windows.Forms.TextBox miscTextBox;
        private System.Windows.Forms.TextBox haircutsTextBox;
        private System.Windows.Forms.TextBox houseutilitiesTextBox;
        private System.Windows.Forms.TextBox carannualpayTextBox;
        private System.Windows.Forms.TextBox phonecontractTextBox;
        private System.Windows.Forms.TextBox carinsuranceTextBox;
        private System.Windows.Forms.TextBox insurancecopayTextBox;
        private System.Windows.Forms.TextBox taxesTextBox;
        private System.Windows.Forms.TextBox _401kTextBox;
        private System.Windows.Forms.Label _401kLabel;
        private System.Windows.Forms.TextBox extraIncomeTextBox;
        private System.Windows.Forms.TextBox mainIncomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

