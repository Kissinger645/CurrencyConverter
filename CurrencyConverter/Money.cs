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
        //StreamReader sr = new StreamReader(@"..\..\Currency.txt");
        //set first value = symbol and second value = rate
        //double BTC = 0.00115368;
        //double JPY = 113.622;
        //double EUR = 0.937635;
        //double USD = 1;
        double rate;
        string symbol;

        public Money()
        {

        }

        public Money(double _rate, string _symbol)
        {
            rate = _rate;
            symbol = _symbol;

        }



    }
}

