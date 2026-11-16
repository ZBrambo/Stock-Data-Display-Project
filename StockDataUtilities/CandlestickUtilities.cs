using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataUtilities
{
    /// <summary>
    /// Provides utility methods for working with candlestick data.
    /// </summary>
    public static class CandlestickUtilities
    {
        /// <summary>
        /// Reads candlestick data from a CSV file.
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <returns></returns>
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <returns></returns>
        public static List<aCandlestick> ReadCandlesticksFromFile(string csvFilePath)
        {
            // Create a list to hold the candlestick objects
            List<aCandlestick> candlesticks = new List<aCandlestick>();

            // Read all lines from the CSV file
            string[] csvLines = File.ReadAllLines(csvFilePath);

            // Skip the header line and process each subsequent line
            foreach (string csvLine in csvLines.Skip(1))
            {
                // Split the line into values based on the comma delimiter
                string[] csvValues = csvLine.Split(',');

                // Ensure that the line has the expected number of values (6 in this case)
                if (csvValues.Length == 6)
                {
                    candlesticks.Add(new aCandlestick(csvValues));
                }
            }

            // Sort the candlesticks by date in ascending order and return the list
            return candlesticks.OrderBy(candlestick => candlestick.Date).ToList();
        }


        /// <summary>
        /// Converts a list of regular candlesticks to a list of smart candlesticks.
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public static List<aSmartCandlestick> ConvertToSmartCandlesticks(List<aCandlestick> candlesticks) 
        {
            // Create a list to hold the aSmartCandlestick objects
            List<aSmartCandlestick> smartCandlesticks = new List<aSmartCandlestick>();

            // Convert each aCandlestick to a aSmartCandlestick and add it to the list
            for (int candlectickIndex = 0; candlectickIndex < candlesticks.Count; candlectickIndex++) 
            { 
                smartCandlesticks.Add(new aSmartCandlestick (candlesticks[candlectickIndex], candlectickIndex));
            }

            return smartCandlesticks;
        }

        /// <summary>
        /// Marks the peaks and valleys in a list of smart candlesticks.
        /// </summary>
        /// <param name="smartCandlesticks"></param>
        public static void MarkPeaksAndValleys(List<aSmartCandlestick> smartCandlesticks) 
        {
            // Iterate through the smart candlesticks starting from the third one (index 2)
            for (int counter = 0; counter < smartCandlesticks.Count; counter++)
            {
                // Ensure that there are at least two previous candlesticks to compare with
                if (counter >= 2)
                {
                    aSmartCandlestick previousCandlestick = smartCandlesticks[counter - 2];
                    aSmartCandlestick currentCandlestick = smartCandlesticks[counter - 1];
                    aSmartCandlestick nextCandlestick = smartCandlesticks[counter];

                    // Check if the current candlestick is a peak (higher than both its neighbors)
                    currentCandlestick.IsPeak = previousCandlestick.High < currentCandlestick.High && nextCandlestick.High < currentCandlestick.High;

                    // Check if the current candlestick is a valley (lower than both its neighbors)
                    currentCandlestick.IsValley = previousCandlestick.Low > currentCandlestick.Low && nextCandlestick.Low > currentCandlestick.Low;
                }
            }
            // The first and last candlesticks cannot be peaks or valleys, so we explicitly set them to false
        }

        /// <summary>
        /// Filters a list of smart candlesticks by a date range.
        /// </summary>
        /// <param name="smartCandlesticks"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static List<aSmartCandlestick> FilterByDateRange(List<aSmartCandlestick>smartCandlesticks, DateTime startDate, DateTime endDate)
        {
            // Ensure that the start date is less than or equal to the end date by swapping them if necessary
            if (startDate > endDate)
            {
                DateTime swappedDate = startDate;
                startDate = endDate;
                endDate = swappedDate;
            }

            // Filter the smart candlesticks to include only those within the specified date range and return the filtered list
            return smartCandlesticks.Where(candlestick => candlestick.Date.Date >= startDate.Date && candlestick.Date.Date <= endDate.Date).ToList();
        }
    }
}
