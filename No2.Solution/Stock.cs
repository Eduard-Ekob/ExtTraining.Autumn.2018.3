using System;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoEventArgs> CurrencyChanged;

        protected virtual void OnCurrencyChanged(StockInfoEventArgs e)
        {
            if (CurrencyChanged != null) CurrencyChanged(this, e);
        }

        public void Market()
        {
            StockInfoEventArgs stocksInfo = new StockInfoEventArgs();            
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            this.OnCurrencyChanged(stocksInfo);
        }
    }
}