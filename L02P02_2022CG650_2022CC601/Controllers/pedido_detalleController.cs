using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using L02P02_2022CG650_2022CC601.Models;

namespace L02P02_2022CG650_2022CC601.Controllers
{
    public class pedido_detalleController : Controller
    {

        private readonly libreriaDbContext _libreriaDbContext;

        public pedido_detalleController(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
