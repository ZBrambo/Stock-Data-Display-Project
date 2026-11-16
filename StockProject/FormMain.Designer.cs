namespace StockProject
{
    partial class FormMain
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
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonStockFile = new System.Windows.Forms.Button();
            this.openFileDialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(103, 82);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(65, 13);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(103, 131);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(60, 13);
            this.labelEndDate.TabIndex = 1;
            this.labelEndDate.Text = "End Date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(238, 75);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            this.dateTimePickerStartDate.Value = new System.DateTime(2026, 6, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(238, 131);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            this.dateTimePickerEndDate.Value = new System.DateTime(2026, 9, 18, 0, 0, 0, 0);
            // 
            // buttonStockFile
            // 
            this.buttonStockFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockFile.Location = new System.Drawing.Point(197, 190);
            this.buttonStockFile.Name = "buttonStockFile";
            this.buttonStockFile.Size = new System.Drawing.Size(101, 35);
            this.buttonStockFile.TabIndex = 0;
            this.buttonStockFile.Text = "&Choose File";
            this.buttonStockFile.UseVisualStyleBackColor = true;
            this.buttonStockFile.Click += new System.EventHandler(this.buttonStockFile_Click);
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.DefaultExt = "csv";
            this.openFileDialogSelectFile.FileName = "NVDA_daily.csv";
            this.openFileDialogSelectFile.Filter = "All Files|*.*|Daily|*_daily.csv|Weekly|*_weekly.csv|Monthly|*_monthly.csv|Yearly|" +
    "*_yearly.csv";
            this.openFileDialogSelectFile.InitialDirectory = "Stock Data";
            this.openFileDialogSelectFile.Multiselect = true;
            this.openFileDialogSelectFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSelectFile_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 265);
            this.Controls.Add(this.buttonStockFile);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Name = "FormMain";
            this.Text = "Stock Selection Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonStockFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFile;
    }
}

