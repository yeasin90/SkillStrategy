using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.TraditionalObserver
{
    public abstract class AbstractObserver
    {
        public abstract void Update();
    }

    public class GoogleObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }

        public GoogleObserver(StockTicker subj)
        {
            this.DataSource = subj;
            subj.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if(symbol == "GOOG")
                Console.WriteLine("Google's new price is : {0}", price);
        }
    }

    public class MicrosoftObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }

        public MicrosoftObserver(StockTicker subj)
        {
            this.DataSource = subj;
            subj.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if(symbol == "GOOG")
                Console.WriteLine("Microsoft has reached the target price: {0}", price);
        }
    }

    public class StockTicker : AbsrtactSubject
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                this.Notify();
            }
        }
    }

    public abstract class AbsrtactSubject
    {
        List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Register(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(AbstractObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
                o.Update();
        }
    }

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
