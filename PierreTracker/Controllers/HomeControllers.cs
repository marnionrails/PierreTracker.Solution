using Microsoft.AspNetCore.Mvc;

namespace Models.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}