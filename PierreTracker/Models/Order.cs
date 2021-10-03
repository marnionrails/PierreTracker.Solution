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

    public Order(string title, string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Now.ToShortDateString();
    }


  }
   
}