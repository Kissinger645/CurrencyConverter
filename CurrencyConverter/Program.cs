using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {

        static void Main(string[] args)
        {
            Money USD = new Money("USD", 1);
            Money BTC = new Money("BTC", 0.00115368);
            Money JPY = new Money("JPY", 113.622);
            Money EUR = new Money("EUR", 0.937635);
            double amount = 0.0;
            double newAmount = 0.0;
            double currencyToRate = 0.0;
            string currencyFrom = "nada";
            string currencyTo = "nada";

            Console.WriteLine("Enter Amount That You Would Like Converted");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose currency you are converting from: USD, JPY, EUR or BTC");
            currencyFrom = Console.ReadLine().ToUpper();
            Console.WriteLine("Choose currency to convert to: USD, JPY, EUR or BTC");
            currencyTo = Console.ReadLine().ToUpper();
            currencyToRate = Convert(amount, currencyFrom, currencyTo);
            Console.WriteLine($"{amount} {currencyFrom} = {newAmount} {currencyTo}");

            Console.ReadKey();
        }
    }
}
