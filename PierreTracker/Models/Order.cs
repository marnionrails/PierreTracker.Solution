using System.Collections.Generic;
using System;

namespace PierreTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public decimal Price {get; set;}
    public string Date {get;}

    public int Id {get;}

     private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Now.ToShortDateString();
       _instances.Add(this);
       Id = _instances.Count;
    }

     public static List<Order> GetAll()
    {
      return _instances;
    }
       public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
   
}