using Microsoft.AspNetCore.Mvc;

namespace L02P02_2022CG650_2022CC601.Controllers
{
    public class clientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
