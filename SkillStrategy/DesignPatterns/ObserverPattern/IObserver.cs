using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.IObserver
{
    public class MicrosoftMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured int the stock ticker");
        }

        public void OnNext(Stock value)
        {
            if (value.Symbol == "GOOG")
                Console.WriteLine("Google's new price is : {0}", value.Price);
        }
    }

    public class GoogleMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured int the stock ticker");
        }

        public void OnNext(Stock value)
        {
            if (value.Symbol == "MSFT" && value.Price > 10.00m)
                Console.WriteLine("Micrsoft has reached the target price : {0}", value.Price);
        }
    }

    public class StockTicker : IObservable<Stock>
    {
        List<IObserver<Stock>> observers = new List<IObserver<Stock>>();
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                this.Notify(this.stock);
            }
        }

        private void Notify(Stock s)
        {
            foreach (var o in observers)
            {
                if(s.Symbol == null || s.Price < 0)
                    o.OnError(new Exception("Bad Stock Data"));
                else
                    o.OnNext(s);
            }
        }

        private void Stop()
        {
            foreach (var observer in observers.ToArray())
            {
                if (observers.Contains(observer))
                    observer.OnCompleted();

                observers.Clear();
            }
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
    }

    class Unsubscriber : IDisposable
    {
        private List<IObserver<Stock>> _observers;
        private IObserver<Stock> _observer;

        public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
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
