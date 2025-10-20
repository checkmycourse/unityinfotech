using Microsoft.AspNetCore.Mvc;

namespace UnityInfotech.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}