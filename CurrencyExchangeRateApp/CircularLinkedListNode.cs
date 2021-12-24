using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRateApp
{

    public class Circularlist
    {
        private float currentdata;
        private Circularlist nextdata;
        public Circularlist()
        {
            currentdata = 0;
            nextdata = this;
        }
        public Circularlist(int currencyValue)
        {
            currentdata = currencyValue;
            nextdata = this;
        }
        public Circularlist Insdata(int currencyValue)
        {
            Circularlist node = new Circularlist(currencyValue);
            if (this.nextdata == this)
            {
                node.nextdata = this;
                this.nextdata = node;
            }
            else
            {
                Circularlist temp = this.nextdata;
                node.nextdata = temp;
                this.nextdata = node;
            }
            return node;
        }
    }
}
