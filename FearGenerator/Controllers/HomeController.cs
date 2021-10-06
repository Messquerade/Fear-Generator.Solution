using Microsoft.AspNetCore.Mvc;

namespace FearGenerator.Controllers
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