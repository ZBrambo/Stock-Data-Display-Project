namespace StockProject
{
    partial class FormChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSourceCandlestick = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerChartStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerChartEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelChartStartDate = new System.Windows.Forms.Label();
            this.labelChartEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandlestick)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStockData
            // 
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartAreaOHLC";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 70F;
            chartArea1.Position.Width = 90F;
            chartArea2.AlignWithChartArea = "ChartAreaOHLC";
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartAreaVolume";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 30F;
            chartArea2.Position.Width = 90F;
            chartArea2.Position.Y = 70F;
            this.chartStockData.ChartAreas.Add(chartArea1);
            this.chartStockData.ChartAreas.Add(chartArea2);
            this.chartStockData.DataSource = this.bindingSourceCandlestick;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartStockData.Legends.Add(legend1);
            this.chartStockData.Location = new System.Drawing.Point(12, 12);
            this.chartStockData.Name = "chartStockData";
            series1.ChartArea = "ChartAreaOHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceUpColor=Green, PriceDownColor=Red";
            series1.Legend = "Legend1";
            series1.Name = "SeriesCandlesticks";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "High, Low, Open, Close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartAreaVolume";
            series2.Legend = "Legend1";
            series2.Name = "SeriesVolume";
            series2.XValueMember = "Date";
            series2.YValueMembers = "Volume";
            this.chartStockData.Series.Add(series1);
            this.chartStockData.Series.Add(series2);
            this.chartStockData.Size = new System.Drawing.Size(715, 426);
            this.chartStockData.TabIndex = 0;
            this.chartStockData.Text = "chart1";
            // 
            // bindingSourceCandlestick
            // 
            this.bindingSourceCandlestick.DataSource = typeof(StockDataUtilities.aSmartCandlestick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(855, 390);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(163, 48);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "&Update Chart";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerChartStartDate
            // 
            this.dateTimePickerChartStartDate.Location = new System.Drawing.Point(855, 143);
            this.dateTimePickerChartStartDate.Name = "dateTimePickerChartStartDate";
            this.dateTimePickerChartStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerChartStartDate.TabIndex = 2;
            // 
            // dateTimePickerChartEndDate
            // 
            this.dateTimePickerChartEndDate.Location = new System.Drawing.Point(855, 207);
            this.dateTimePickerChartEndDate.Name = "dateTimePickerChartEndDate";
            this.dateTimePickerChartEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerChartEndDate.TabIndex = 3;
            // 
            // labelChartStartDate
            // 
            this.labelChartStartDate.AutoSize = true;
            this.labelChartStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartStartDate.Location = new System.Drawing.Point(784, 143);
            this.labelChartStartDate.Name = "labelChartStartDate";
            this.labelChartStartDate.Size = new System.Drawing.Size(65, 13);
            this.labelChartStartDate.TabIndex = 4;
            this.labelChartStartDate.Text = "Start Date";
            // 
            // labelChartEndDate
            // 
            this.labelChartEndDate.AutoSize = true;
            this.labelChartEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartEndDate.Location = new System.Drawing.Point(784, 213);
            this.labelChartEndDate.Name = "labelChartEndDate";
            this.labelChartEndDate.Size = new System.Drawing.Size(60, 13);
            this.labelChartEndDate.TabIndex = 5;
            this.labelChartEndDate.Text = "End Date";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 473);
            this.Controls.Add(this.labelChartEndDate);
            this.Controls.Add(this.labelChartStartDate);
            this.Controls.Add(this.dateTimePickerChartEndDate);
            this.Controls.Add(this.dateTimePickerChartStartDate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.chartStockData);
            this.Name = "FormChart";
            this.Text = "Stock Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandlestick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockData;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerChartStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerChartEndDate;
        private System.Windows.Forms.Label labelChartStartDate;
        private System.Windows.Forms.Label labelChartEndDate;
        private System.Windows.Forms.BindingSource bindingSourceCandlestick;
    }
}