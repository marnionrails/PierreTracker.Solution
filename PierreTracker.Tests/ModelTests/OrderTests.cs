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
      string result = testOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
      public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      string result = testOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
      public void GetPrice_ReturnsPrice_Decimal()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      decimal result = testOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }
    [TestMethod]
      public void GetTime_ReturnsTime_DateTime()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      string date = DateTime.Now.ToShortDateString();
      string result = testOrder.Date;
      //Assert
      Assert.AreEqual(date, result);
    }
  

  }
}
