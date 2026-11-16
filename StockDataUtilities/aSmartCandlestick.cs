using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataUtilities
{
    /// <summary>
    /// Represents a smart candlestick with additional properties for analysis.
    /// </summary>
    public class aSmartCandlestick : aCandlestick
    {
        /// <summary>
        /// Gets or sets the index of the smart candlestick.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the smart candlestick is a peak.
        /// </summary>
        public bool IsPeak { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the smart candlestick is a valley. 
        /// </summary>
        public bool IsValley { get; set; }

        /// <summary>
        /// Initializes a new instance of the aSmartCandlestick class with the specified original candlestick and index.
        /// </summary>
        /// <param name="originalCandlestick"></param>
        /// <param name="index"></param>
        public aSmartCandlestick(aCandlestick originalCandlestick, int index)
            // Call the base constructor to initialize the properties of the aCandlestick class
            : base(originalCandlestick.Date, 
                  originalCandlestick.Open, 
                  originalCandlestick.High, 
                  originalCandlestick.Low, 
                  originalCandlestick.Close, 
                  originalCandlestick.Volume)
        {
            // Set the Index property to the provided index
            Index = index;

            // Initialize IsPeak and IsValley to false by default
            IsPeak = false;
            IsValley = false;
        }
    }
}
