using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CurrencyConverter
{
     class Money
    {
        StreamReader sr = new StreamReader(@"..\..\Currency.txt");
        //set first value = symbol and second value = rate
        double rate;
        string symbol;
        double currencyFromRate = 0;
        double currencyToRate = 0;

        public var Convert()
        {
            Console.WriteLine("Enter Amount That You Would Like Converted");
            float amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose currency you are converting from: USD, JPY, EUR or BTC");//change once finished
            var currencyFrom = Console.ReadLine();
            // if currencyFrom is in the currency list set currencyFromRate = rate
            // else give error
            Console.WriteLine("Choose currency to convert to: USD, JPY, EUR or BTC");
            var currencyTo = Console.ReadLine();
            // if currencyTo is in the list set currencyToRate = rate
            //else give error
            var newAmount = (amount / currencyFromRate * currencyToRate);
            Console.WriteLine($"{amount} {currencyFrom} = {newAmount} {currencyTo}");

        }
        
        
    }
}

//double BTC = 0.00115368;
//double JPY = 113.622;
//double EUR = 0.937635;
//double USD = 1;