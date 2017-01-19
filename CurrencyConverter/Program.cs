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

            double currencyFromRate = 0.0;
            double currencyToRate = 0.0;
            string currencyFrom = "nada";
            string currencyTo = "nada";
            float amount = 0.0f;

            Dictionary<string, double> currency = new Dictionary<string, double>();
            currency.Add("USD", 1);
            currency.Add("BTC", .00115368);
            currency.Add("EUR", .937635);
            currency.Add("JPY", 113.622);

            Console.WriteLine("Enter Amount That You Would Like Converted");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose currency you are converting from: USD, JPY, EUR or BTC");
            currencyFrom = Console.ReadLine();

            // if currencyFrom is in the currency list set currencyFromRate = rate
            // else give error

            if (currency.TryGetValue(currencyFrom, out currencyFromRate))
            {
                
            }
            else
            {
                Console.WriteLine("Try another symbol");
            }

            Console.WriteLine("Choose currency to convert to: USD, JPY, EUR or BTC");
            currencyTo = Console.ReadLine();

            // if currencyTo is in the list set currencyToRate = rate
            //else give error

            if (currency.TryGetValue(currencyTo, out currencyToRate))
            {

            }
            else
            {
                Console.WriteLine("Try another symbol");
            }
            
            var newAmount = amount / currencyFromRate * currencyToRate;
            Console.WriteLine($"{amount} {currencyFrom} = {newAmount} {currencyTo}");

            Console.ReadKey();



        }
    }
}
