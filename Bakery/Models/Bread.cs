using System;
using System.Collections.Generic; 

namespace Bakery
{
  public class Bread
  {
        private int _PricePerLoaf = 5;
        public int PricePerLoaf
        {
            get { return _PricePerLoaf; }
            set { _PricePerLoaf = value; }
        }

        private int _LoafsPerDeal = 3;
        public int LoafsPerDeal
        {
            get { return _LoafsPerDeal; }
            set { _LoafsPerDeal = value; }
        }

        public Bread(int pricePerLoaf, int loafsPerDeal)
        {
            PricePerLoaf = pricePerLoaf;
            LoafsPerDeal = loafsPerDeal;
        }

    
  }
}