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
                    return 0.00101;
                    break;
                  
                case "JPY":
                    return 112.400;
                    break;
                    
                case "EUR":
                    return .92523;
                    break;
                    
                case "USD":
                    return 1;
                    break;
                default:
                    return 0;
                    break;
            }
            
        }

    }
}

