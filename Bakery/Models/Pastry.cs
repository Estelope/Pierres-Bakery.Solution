using System;
using System.Collections.Generic; 

namespace Bakery
{
    public class Pastry
    {
        private int _PricePerPastry = 2;
        public int PricePerPastry
        {
            get { return _PricePerPastry; }
            set { _PricePerPastry = value; }
        }

        private int _PastriesPerDeal = 4;
        public int PastriesPerDeal
        {
            get { return _PastriesPerDeal; }
            set { _PastriesPerDeal = value; }
        }

        public Pastry(int pricePerPastry, int pastriesPerDeal)
        {
            PricePerPastry = pricePerPastry;
            PastriesPerDeal = pastriesPerDeal;
        }
    }
}