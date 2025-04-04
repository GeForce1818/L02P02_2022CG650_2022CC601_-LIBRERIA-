using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using L02P02_2022CG650_2022CC601.Models;

namespace L02P02_2022CG650_2022CC601.Controllers
{
    public class categoriasController : Controller
    {

        private readonly LibreriaBDContext _LibreriaBDContext;

        public categoriasController(LibreriaBDContext LibreriaBDContext)
        {
            _LibreriaBDContext = LibreriaBDContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
