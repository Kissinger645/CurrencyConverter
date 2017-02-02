using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {

        static string Read(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            bool runagain = true;

            while (runagain == true)
            {
                MoneyConversion();
            }
            
        }

        private static void MoneyConversion()
        {
            double amount = double.Parse(Read("Enter Amount That You Would Like Converted"));
            string currencyFrom = Read("Choose currency you are converting from: USD, JPY, EUR or BTC").ToUpper();
            double A = Money.GetRate(currencyFrom);
            string currencyTo = Read("Choose currency you are converting to: USD, JPY, EUR or BTC").ToUpper();
            double B = Money.GetRate(currencyTo);
            double newAmount = Money.Convert(amount, A, B);
            Console.WriteLine($"{amount} {currencyFrom} = {newAmount} {currencyTo}");           
        }
    }
}
