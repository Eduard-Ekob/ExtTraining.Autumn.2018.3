using System;

namespace No2.Solution
{
    public class Bank
    {
        public readonly string Name;
        private object stock;
        public object Stock { get ; private set ; }
        public Bank(string name, object sender)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Stock = sender ?? throw new ArgumentNullException(nameof(sender));
        }        

        public void Update(object sender, StockInfoEventArgs args)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Stock = sender;
            Console.WriteLine(
                args.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{args.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {args.Euro}");
        }
    }
}