using Microsoft.AspNetCore.Mvc;

namespace ornek01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewResult result = View();
            //return View();//
            return result;
        }

    
    }
}
