using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject
{
    /// <summary>
    /// Starting form for the stock chart application. Allows the user to select one or more stock data files and specify a date range for the charts.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Creates the main form, initializes components, and sets the initial directory for the file dialog to the "Stock Data" folder if it exists in the current or parent directories.
        /// </summary>
        public FormMain()
        {
            // Initialize the form and its components
            InitializeComponent();

            // Set the initial directory for the open file dialog to the "Stock Data" folder if it exists in the current or parent directories
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Traverse up the directory tree until we find a directory that contains "Stock Data" or we reach the root
            while (currentDirectory != null && !Directory.Exists(Path.Combine(currentDirectory, "Stock Data")))
            {
                currentDirectory = Path.GetDirectoryName(currentDirectory);
            }

            // If we found a directory that contains "Stock Data", set the initial directory of the open file dialog to that folder
            if (currentDirectory != null)
            {
                openFileDialogSelectFile.InitialDirectory = Path.Combine(currentDirectory, "Stock Data");
            }
        }


        /// <summary>
        /// Opens a file dialog to select one or more stock data files when the "Select Stock File" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStockFile_Click(object sender, EventArgs e)
        {
            // Show the open file dialog to select one or more stock data files
            openFileDialogSelectFile.ShowDialog();
        }

        /// <summary>
        ///  Runs after the user selects one or more stock data files in the open file dialog. It retrieves the selected date range and opens a new FormChart for each selected stock data file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialogSelectFile_FileOk(object sender, CancelEventArgs e)
        {
            // Get the start and end dates from the date pickers
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date;

            // Open a new FormChart for each selected stock data file
            foreach (string stockFilePath in openFileDialogSelectFile.FileNames)
            {
                // Create a new FormChart instance with the selected stock file and date range
                FormChart stockChartForm = new FormChart(stockFilePath, startDate, endDate);
                stockChartForm.Show();
            }
        }
    }
}
