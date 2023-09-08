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
        Bread bread = new Bread(5,3);
        Assert.AreEqual(typeof(Bread) , bread.GetType());
    }

    [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {               
        Pastry pastry = new Pastry(5,3);     
        Assert.AreEqual(typeof(Pastry) , pastry.GetType());
    }

    [TestMethod]
      public void PastryConstructor_GetterAndSetterWork()
      {
        int pricePerPastry = 2;
        int pastriesPerDeal = 4;
        Pastry pastry = new Pastry(pricePerPastry, pastriesPerDeal);
        Assert.AreEqual(pricePerPastry, pastry.PricePerPastry);
        Assert.AreEqual(pastriesPerDeal, pastry.PastriesPerDeal);
        }

    [TestMethod]
      public void BreadConstructor_GetterAndSetterWork()
      {
        int pricePerLoaf = 5;
        int loafsPerDeal = 3;
        Bread bread = new Bread(pricePerLoaf, loafsPerDeal);
        Assert.AreEqual(pricePerLoaf, bread.PricePerLoaf);
        Assert.AreEqual(loafsPerDeal, bread.LoafsPerDeal);
        }

    [TestMethod]
      public void BreadCalculateCost_CalculatesCorrectCost()
      {   
        Bread bread = new Bread(5, 3); 
        int cost1 = bread.CalculateBreadCost(3); 
        int cost2 = bread.CalculateBreadCost(5); 
        Assert.AreEqual(10, cost1);
        Assert.AreEqual(20, cost2);
      }

    [TestMethod]
      public void PastryCalculateCost_CalculatesCorrectCost()
        {
        Pastry pastry = new Pastry(2, 4); 
        int cost1 = pastry.CalculateCost(3); 
        int cost2 = pastry.CalculateCost(6);
        Assert.AreEqual(6, cost1);
        Assert.AreEqual(12, cost2);
        }

  }
}