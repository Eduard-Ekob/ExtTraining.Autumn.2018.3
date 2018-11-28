using System;

namespace No2.Solution
{
    public class Broker
    {
        public readonly string Name;
        private object stock;
        public object Stock { get ; private set; }
        public Broker(string name, object sender)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Stock = sender;
        }        

        public void Update(object sender, StockInfoEventArgs args)
        {            
            Console.WriteLine(
                args.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {args.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {args.USD}");
        }
    }
}