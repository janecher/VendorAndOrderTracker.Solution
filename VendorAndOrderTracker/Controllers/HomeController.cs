using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controllers
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