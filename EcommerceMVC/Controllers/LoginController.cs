using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
