using System;
using System.Collections.Generic; 

namespace Bakery
{
  public class Bread
  {
         public int PricePerLoaf { get; set; } = 5;
        public int LoafsPerDeal { get; set; } = 3;

        public Bread(int pricePerLoaf, int loafsPerDeal)
        {
            PricePerLoaf = pricePerLoaf;
            LoafsPerDeal = loafsPerDeal;
        }
        public int CalculateBreadCost(int quantity)
        {
            int setsOfThree = quantity / LoafsPerDeal;
            int remainingLoaves = quantity % LoafsPerDeal;
            int totalCost = (setsOfThree * 2 + remainingLoaves) * PricePerLoaf;
            return totalCost;
        }
  }
}