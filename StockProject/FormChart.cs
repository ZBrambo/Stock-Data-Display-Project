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
using System.Windows.Forms.DataVisualization.Charting;
using StockDataUtilities;

namespace StockProject
{
    /// <summary>
    /// Shows one stock as a candlestick chart with a volume chart underneath.
    /// Peaks are marked with "P" and valleys with "V".
    /// Has its own date pickers and Refresh button to show a different date range.
    /// </summary>
    public partial class FormChart : Form
    {
        /// <summary>
        /// Private list of SmartCandlestick objects.
        /// </summary>
        private List<aSmartCandlestick> allSmartCandlesticks;

        /// <summary>
        /// Only the SmartCandlestick objects that are currently displayed on the chart, based on the selected date range.
        /// </summary>
        private List<aSmartCandlestick> displayedSmartCandlesticks;

        /// <summary>
        /// Rubberbanding state to be added later
        /// </summary>
        private bool isRubberBanding = false;
        private Point rubberBandStartPoint = Point.Empty;
        private Point rubberBandEndPoint = Point.Empty;


        /// <summary>
        /// Creates a chart window for one stock, with the given stock file path and date range.
        /// </summary>
        /// <param name="stockFilePath"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public FormChart(string stockFilePath, DateTime startDate, DateTime endDate)
        {
            // Initialize the form and its components
            InitializeComponent();

            // Set the form title to the stock file name without extension
            Text = Path.GetFileNameWithoutExtension(stockFilePath);

            // Set the date pickers to the provided start and end dates
            dateTimePickerChartStartDate.Value = startDate;
            dateTimePickerChartEndDate.Value = endDate;

            // Read the candlestick data from the file and convert it to SmartCandlestick objects
            List<aCandlestick> candlesticksFromFile = CandlestickUtilities.ReadCandlesticksFromFile(stockFilePath);
            allSmartCandlesticks = CandlestickUtilities.ConvertToSmartCandlesticks(candlesticksFromFile);
            CandlestickUtilities.MarkPeaksAndValleys(allSmartCandlesticks);

            // Display the chart with the initial date range
            DisplayChart();
        }

        /// <summary>
        /// Filters the candlestick data based on the selected date range and updates the chart accordingly. It also adds annotations for peaks and valleys.
        /// </summary>
        private void DisplayChart()
        {
            // Filter the SmartCandlestick objects based on the selected date range
            displayedSmartCandlesticks = CandlestickUtilities.FilterByDateRange(allSmartCandlesticks, dateTimePickerChartStartDate.Value, dateTimePickerChartEndDate.Value);

            // Set the filtered data as the data source for the chart and bind it
            chartStockData.DataSource = displayedSmartCandlesticks;
            chartStockData.DataBind();

            // Add annotations for peaks and valleys on the chart
            AddPeakAndValleyAnnotations();
        }


        /// <summary>
        /// Removes existing annotations and adds new annotations for peaks and valleys on the chart. Peaks are marked with a green "P" above the candlestick, and valleys are marked with a red "V" below the candlestick.
        /// </summary>
        private void AddPeakAndValleyAnnotations()
        {
            // Clear existing annotations
            chartStockData.Annotations.Clear();

            // Get the chart area and series for candlesticks
            ChartArea candlestickChartArea = chartStockData.ChartAreas["ChartAreaOHLC"];
            Series candlestickSeries = chartStockData.Series["SeriesCandlesticks"];

            // Loop through the displayed SmartCandlestick objects and add annotations for peaks and valleys
            for (int pointIndex = 0; pointIndex < displayedSmartCandlesticks.Count; pointIndex++)
            {
                aSmartCandlestick currentCandlestick = displayedSmartCandlesticks[pointIndex];
                double pointXValue = candlestickSeries.Points[pointIndex].XValue;

                // Add a peak annotation if the current candlestick is marked as a peak
                if (currentCandlestick.IsPeak)
                {
                    // Create a green "P" annotation above the peak candlestick
                    TextAnnotation peakAnnotation = CreateMarkerAnnotation("P", Color.Green, candlestickChartArea, pointXValue, currentCandlestick.High);
                    peakAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
                    chartStockData.Annotations.Add(peakAnnotation);
                }

                // Add a valley annotation if the current candlestick is marked as a valley
                if (currentCandlestick.IsValley)
                {
                    // Create a red "V" annotation below the valley candlestick
                    TextAnnotation valleyAnnotation = CreateMarkerAnnotation("V", Color.Red, candlestickChartArea, pointXValue, currentCandlestick.Low);
                    valleyAnnotation.AnchorAlignment = ContentAlignment.TopCenter;
                    chartStockData.Annotations.Add(valleyAnnotation);
                }
            }
        }

        /// <summary>
        /// Builds a TextAnnotation for marking peaks and valleys on the chart. The annotation is created with the specified text, color, chart area, and anchor coordinates.
        /// </summary>
        /// <param name="markerText"></param>
        /// <param name="markerColor"></param>
        /// <param name="candlestickChartArea"></param>
        /// <param name="anchorXValue"></param>
        /// <param name="anchorYValue"></param>
        /// <returns></returns>
        private TextAnnotation CreateMarkerAnnotation(string markerText, Color markerColor, ChartArea candlestickChartArea, double anchorXValue, double anchorYValue)
        {
            TextAnnotation markerAnnotation = new TextAnnotation();

            // Set the properties of the annotation, including text, color, font, and anchor coordinates
            markerAnnotation.Text = markerText;
            markerAnnotation.ForeColor = markerColor;
            markerAnnotation.Font = new Font("Arial", 10, FontStyle.Bold);

            // Set the annotation's axis and anchor values to position it correctly on the chart
            markerAnnotation.AxisX = candlestickChartArea.AxisX;
            markerAnnotation.AxisY = candlestickChartArea.AxisY;
            markerAnnotation.AnchorX = anchorXValue;
            markerAnnotation.AnchorY = anchorYValue;

            // Ensure the annotation is clipped to the chart area to prevent it from going outside the chart bounds
            markerAnnotation.ClipToChartArea = candlestickChartArea.Name;

            // Return the created annotation for use in the chart
            return markerAnnotation;
        }

        /// <summary>
        ///  Redraws the chart based on the selected date range when the "Update" button is clicked. This method is triggered by the button's click event and calls the DisplayChart method to refresh the chart with the new date range.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update the chart based on the selected date range
            DisplayChart();
        }
    }
}
