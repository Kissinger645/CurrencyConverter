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
        double rate;
        string symbol;
        double currencyFromRate = 0;
        double currencyToRate = 0;

            Dictionary<string, double> currency = new Dictionary<string, double>();
            currency.Add("USD", 1);
            currency.Add("BTC", .00115368);
            currency.Add("EUR", .937635);
            currency.Add("JPY", 113.622);

            Console.WriteLine("Enter Amount That You Would Like Converted");
            float amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose currency you are converting from: USD, JPY, EUR or BTC");//change once finished
            var currencyFrom = Console.ReadLine();

            // if currencyFrom is in the currency list set currencyFromRate = rate
            // else give error
            if (currency.ContainsKey(currencyFrom))
            {
                currencyFromRate = currency["currencyFrom"];
            }

            Console.WriteLine("Choose currency to convert to: USD, JPY, EUR or BTC");
            var currencyTo = Console.ReadLine();

            // if currencyTo is in the list set currencyToRate = rate
            //else give error
            if (currency.ContainsKey(currencyTo))
            {
                currencyToRate = currency["currencyTo"];
            }
            var newAmount = amount / currencyFromRate * currencyToRate;
            Console.WriteLine($"{amount} {currencyFrom} = {newAmount} {currencyTo}");



        }
    }
}
