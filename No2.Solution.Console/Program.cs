using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using No2.Solution;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank", stock);
            var broker = new Broker("Broker", stock);

            stock.CurrencyChanged += bank.Update;
            stock.CurrencyChanged += broker.Update;

            for (int i = 0; i < 30; i++)
            {
                stock.Market();
                Thread.Sleep(200);
            }
            
            System.Console.ReadLine();
        }
    }
}
