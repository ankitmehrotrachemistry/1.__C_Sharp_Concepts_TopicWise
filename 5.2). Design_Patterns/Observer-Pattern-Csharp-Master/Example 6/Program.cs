﻿using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var stockObservable = new StockObservable();
        var microsoftObserver = new MicrosoftStockObserver(stockObservable);
        var googleObserver = new GoogleStockObserver(stockObservable);

        var stockSimulator = new StockSimulator();
        foreach (var stock in stockSimulator)
            stockObservable.Subject = stock;
        Console.ReadLine();
    }

    public class StockObservable
    {
        private Stock subject;

        /*
        an event declared to be public would allow other classes the use of += and -= on
        the event, but firing the event (i.e. invoking the delegate) is only allowed in 
        the class containing the event.

        The EventHandler delegate is a predefined delegate that specifically represents
        an event handler method for an event that generate data of type define in generic
        argument EventHandler<TEventArgs> delegate class.
        */
        public event EventHandler<StockChangeEventArgs> StockChangeEvent = delegate { };

        public Stock Subject
        {
            get => subject;
            set
            {
                subject = value;

                //invoking the delegate
                StockChangeEvent(this, new StockChangeEventArgs(subject));
            }
        }
    }

    //This class represents the data generated by the above event
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(Stock stock)
        {
            Stock = stock;
        }

        public Stock Stock { get; }
    }

    public class GoogleStockObserver
    {
        public GoogleStockObserver(StockObservable stockTicker)
        {
            /*
            GoogleStockObserver can subscribe to the event by adding 
            StockChange method to the event delegate
            */
            stockTicker.StockChangeEvent += StockChange;
        }

        private void StockChange(object sender, StockChangeEventArgs e)
        {
            var data = e.Stock; //gets the data from the event
            if (data.Name == "Google" && data.Price > 50)
                Console.WriteLine($"Google reached target price {data.Price}");
        }
    }

    public class MicrosoftStockObserver
    {
        public MicrosoftStockObserver(StockObservable stockTicker)
        {
            stockTicker.StockChangeEvent += StockChange;
        }

        private void StockChange(object sender, StockChangeEventArgs e)
        {
            var data = e.Stock;
            if (data.Name == "Microsoft")
                Console.WriteLine($"Microsoft new price is {data.Price}");
        }
    }

    public class StockSimulator : IEnumerable<Stock>
    {
        Random random;
        string[] names = new string[3] { "Microsoft", "Google", "Apple" };

        public StockSimulator()
        {
            random = new Random(1024);
        }

        public IEnumerator<Stock> GetEnumerator()
        {
            for (int i = 0; i < 20; i++)
            {
                yield return new Stock(names[random.Next(0, 3)],
                    random.Next(1, 100));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Stock
    {
        public Stock(string name, int value)
        {
            Name = name;
            Price = value;
        }

        public string Name { get; }
        public int Price { get; }
    }

}