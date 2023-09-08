using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        int pricePerLoaf = 5;
        int loafsPerDeal = 3;
        Bread bread = new Bread(pricePerLoaf, LoafsPerDeal);
        Assert.AreEqual(typeof(Bread) , bread.GetType());
    }

    [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {        
        int pricePerPastry = 2;
        int pastriesPerDeal = 4;
        Pastry pastry = new Pastry(pricePerPastry, pastriesPerDeal);     
        Assert.AreEqual(typeof(Pastry) , pastry.GetType());
    }

    [TestMethod]
      public void PastryConstructor_AcceptsInputValues()
      {
        int pricePerPastry = 2;
        int pastriesPerDeal = 4;
        Pastry pastry = new Pastry(pricePerPastry, pastriesPerDeal);
        Assert.AreEqual(pricePerPastry, pastry.PricePerPastry);
        Assert.AreEqual(pastriesPerDeal, pastry.PastriesPerDeal);
        }

    [TestMethod]
      public void BreadConstructor_AcceptsInputValues()
      {
        int pricePerLoaf = 5;
        int loafsPerDeal = 3;
        Bread bread = new Bread(pricePerLoaf, LoafsPerDeal);
        Assert.AreEqual(pricePerLoaf, bread.PricePerLoaf);
        Assert.AreEqual(LoafsPerDeal, bread.LoafsPerDeal);
        }
  }
}