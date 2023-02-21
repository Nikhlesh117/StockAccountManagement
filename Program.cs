namespace StockManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\Work\\Bridgelabz\\.net repo\\StockManagement\\StockManagement\\Stock.json";

            FetchStock fetchStock = new FetchStock();

            StockDetails data = fetchStock.Read(path);

            Console.WriteLine("\nSTOCK VALUE: ");

            for (int i = 0; i < data.stocks.Count; i++)
            {
                Console.WriteLine("\n" + data.stocks[i].Stock);
                Console.WriteLine("shares: " + data.stocks[i].Shares);
                Console.WriteLine("price: " + data.stocks[i].Price);

                int TotalValue = data.stocks[i].Shares * data.stocks[i].Price;
                Console.WriteLine("\nThe Total Value of {0} for {1} shares is: {2} ", data.stocks[i].Stock, data.stocks[i].Shares, TotalValue);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}