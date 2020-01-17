using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()   // This could also be IActionResult
    {
      return View();
    }
    
    // public IActionResult About()
    // {
    //   return View();
    // }
    // public IActionResult Contact()
    // {
    //   return View();
    // }
    // public IActionResult Error()
    // {
    //   return View();
    // }
  }
}