using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
     public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("arguement1", "arguement2");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Kenny's Cafe";
      string description = "Healthy Baked Goods";
      Vendor testVendor = new Vendor(name, description);

      string result = testVendor.Name;

      Assert.AreEqual(name, result);
      
    }
     [TestMethod]
    public void SetName_ReturnsName_String()
    {
      string name = "Kenny's Cafe";
      string description = "Healthy Baked Goods";
      Vendor testVendor = new Vendor(name, description);

      string newName = "John's Cafe";
      testVendor.Name = newName;
      string result = testVendor.Name;

      Assert.AreEqual(newName, result);
      
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Kenny's Cafe";
      string description = "Healthy Baked Goods";
      Vendor testVendor = new Vendor(name, description);

      string result = testVendor.Description;

      Assert.AreEqual(description, result);
      
    }

     [TestMethod]
    public void SetDescription_ReturnsDescription_String()
    {
      string name = "Kenny's Cafe";
      string description = "Healthy Baked Goods";
      Vendor testVendor = new Vendor(name, description);

      string newDescription = "Baked Breakfast Foods";
      testVendor.Description = newDescription;
      string result = testVendor.Description;

      Assert.AreEqual(newDescription, result);
      
    }
       [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor testVendor = new Vendor(name, description);

      //Act
      int result = testVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
     public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Kenny's Cafe";
      string name02 = "The Chocolate Factory";
      string description01 = "Vegan Cafe";
      string description02 = "All chocolate";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Kenny's Cafe";
      string name02 = "The Chocolate Factory";
      string description01 = "Vegan Cafe";
      string description02 = "All chocolate";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
  }
}
