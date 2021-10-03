/* using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;
using System.Collections.Generic;

namespace PierreTracker.Controllers
{
  public class OrdersController : Controller
  {
     [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

     [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

      [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

      [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

     [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }


  }
} */