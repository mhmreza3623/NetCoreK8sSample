using Microsoft.AspNetCore.Mvc;

namespace CoreMinikubeSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
