using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("Argument1", "Argument2", 3.0M);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
      public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      string result = "wrong order";
      //Assert
      Assert.AreEqual(title, result);
    }

  

  }
}
