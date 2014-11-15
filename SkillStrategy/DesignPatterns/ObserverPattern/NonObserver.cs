using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.NonObserver
{
    public class SampleData
    {
        private static decimal[] samplePrices = new decimal[] { 10.00m, 10.25m, 555.55m, 9.50m, 9.03m };
        private static string[] sampleStocks = new string[] { "MSFT", "MSFT", "GOOG", "MSFT", "MSFT" };

        public static IEnumerable<Stock> getNext()
        {
            for (int i = 0; i < samplePrices.Length; i++)
            {
                Stock s = new Stock();
                s.Symbol = sampleStocks[i];
                s.Price = samplePrices[i];
                yield return s;
            }
        }
    }

    public class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
    }
}
