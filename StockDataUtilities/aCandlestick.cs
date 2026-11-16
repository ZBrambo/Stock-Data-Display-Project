using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataUtilities
{
    /// <summary>
    /// Represents a single candlestick in a stock chart, containing the date, open, high, low, close prices, and volume for that day.
    /// </summary>
    public class aCandlestick
    {
        /// <summary>
        /// Gets or sets the date of the candlestick.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the opening price of the candlestick.
        /// </summary>
        public double Open { get; set; }
        /// <summary>
        /// Gets or sets the highest price of the candlestick.
        /// </summary>
        public double High { get; set; }
        /// <summary>
        /// Gets or sets the lowest price of the candlestick.
        /// </summary>
        public double Low { get; set; }
        /// <summary>
        /// Gets or sets the closing price of the candlestick.
        /// </summary>
        public double Close { get; set; }
        /// <summary>
        /// Gets or sets the trading volume of the candlestick.
        /// </summary>
        public double Volume { get; set; }


        /// <summary>
        /// Initializes a new instance of the aCandlestick class with the specified date, open, high, low, close prices, and volume.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="open"></param>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="close"></param>
        /// <param name="volume"></param>
        public aCandlestick(DateTime date, double open, double high, double low, double close, double volume)
        {
            // Initialize the properties with the provided values
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the aCandlestick class with the specified date, open, high, low, close prices, and volume as strings. The string values are parsed to their respective types.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="open"></param>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="close"></param>
        /// <param name="volume"></param>
        public aCandlestick(string date, string open, string high, string low, string close, string volume)
        {
            // Parse the string value to DateTime and assign it to the Date property
            Date = DateTime.Parse(date);
            // Parse the string values to double and assign them to the respective properties
            Open = double.Parse(open);
            High = double.Parse(high);
            Low = double.Parse(low);
            Close = double.Parse(close);
            Volume = double.Parse(volume);
        }


        /// <summary>
        /// Initializes a new instance of the aCandlestick class with an array of string values. The array should contain exactly 6 elements representing the date, open, high, low, close prices, and volume. The string values are parsed to their respective types.
        /// </summary>
        /// <param name="values"></param>
        /// <exception cref="ArgumentException"></exception>
        public aCandlestick(string[] values)
        {
            // Validate that the input array contains exactly 6 elements
            if (values.Length != 6)
            {
                throw new ArgumentException("Invalid number of values provided");
            }
            // Parse the first string value to DateTime using the specified format and assign it to the Date property
            Date = DateTime.ParseExact(values[0].Trim().Trim('\"'), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            // Parse the string values to double and assign them to the respective properties
            Open = double.Parse(values[1]);
            High = double.Parse(values[2]);
            Low = double.Parse(values[3]);
            Close = double.Parse(values[4]);
            Volume = double.Parse(values[5]);
        }
    }
}
