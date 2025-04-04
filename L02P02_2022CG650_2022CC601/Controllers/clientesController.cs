using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using L02P02_2022CG650_2022CC601.Models;

namespace L02P02_2022CG650_2022CC601.Controllers
{
    public class clientesController : Controller
    {

        private readonly LibreriaBDContext _LibreriaBDContext;

        public clientesController(LibreriaBDContext libreriaDbContext)
        {
            _LibreriaBDContext = libreriaDbContext;
        }

        public IActionResult Index()
        {
            var listadoDeClientes = (from c in _LibreriaBDContext.clientes
                                    select new
                                    {
                                        nombre = c.nombre,
                                        apellido = c.apellido,
                                        email = c.email,
                                        direccion = c.direccion,
                                        created_at = c.created_at

                                    }).ToList();
            ViewData["listadoDeClientes"] = listadoDeClientes;

            return View();
        }
    }
}
