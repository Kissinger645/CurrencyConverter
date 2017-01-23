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
        public double Convert(float _amount, float _currencyFromRate, float _currencyToRate)
        {
            amount = _amount;
            currencyFromRate = _currencyFromRate;
            currencyToRate = _currencyToRate;
            return (amount / currencyFromRate * currencyToRate);
        }



    }
}

