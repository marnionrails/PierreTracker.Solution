using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    
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
      public void SetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      string newTitle = "Chocolate Donuts";
      testOrder.Title = newTitle;
      string result = testOrder.Title;
      //Assert
      Assert.AreEqual(newTitle, result);
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
      public void SetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Chocolate Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      string newDescription = "Yummy rich chocolate";
      testOrder.Description = newDescription;
      string result = testOrder.Description;
      //Assert
      Assert.AreEqual(newDescription, result);
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
      public void SetPrice_ReturnsPrice_Decimal()
    {
      //Arrange
      string title = "Cider Donuts";
      string description = "Donuts made of cider and sugar";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);
      //Act
      decimal newPrice = 4.0M;
      testOrder.Price = newPrice;
      decimal result = testOrder.Price;
      //Assert
      Assert.AreEqual(newPrice, result);
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

     [TestMethod]
    public void GetId_ReturnOrderId_Int()
    {
      //Arrange
      string title = "Test Order";
      string description = "Test Description";
      decimal price = 3.0M;
      Order testOrder = new Order(title, description, price);

      //Act
      int result = testOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      //Arrange
      string title01 = "Test Order";
      string description01 = "Test Description";
      decimal price01 = 3.0M;
      string title02 = "Test Order 2";
      string description02 = "Test Description 2";
      decimal price02 = 5.0M;
      Order newOrder1 = new Order(title01, description01, price01);
      Order newOrder2 = new Order(title02, description02, price02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }


  }
}
