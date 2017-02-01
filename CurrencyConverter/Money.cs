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
        double rate;
        string symbol;
        double amount = 0.0;
        double currencyFromRate = 0.0;
        double currencyToRate = 0.0;

        public Money()
        {

        }

        public Money(string _symbol, double _rate)
        {
            rate = _rate;
            symbol = _symbol;
        }

        public static double Convert(double _amount, double _currencyFromRate, double _currencyToRate)
        {
            return ((_amount / _currencyFromRate) * _currencyToRate);
        }

        public static double GetRate(string _symbol)
        {
            switch (_symbol)
            {
                case "BTC":
                    return 0.00115368;
                    break;
                  
                case "JPY":
                    return 113.622;
                    break;
                    
                case "EUR":
                    return .937635;
                    
                case "USD":
                    return 1;
                default:
                    return 0;
                    break;
            }
            
        }

    }
}

