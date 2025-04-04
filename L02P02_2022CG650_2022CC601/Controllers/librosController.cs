using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using L02P02_2022CG650_2022CC601.Models;

namespace L02P02_2022CG650_2022CC601.Controllers
{
    public class librosController : Controller
    {

        private readonly LibreriaBDContext _LibreriaBDContext;

        public librosController(LibreriaBDContext LibreriaBDContext)
        {
            _LibreriaBDContext = LibreriaBDContext;
        }

        public IActionResult Index()
        {
            var listadoDeCategorias = (from ca in _LibreriaBDContext.categorias
                                 select ca).ToList();
            ViewData["listadoDeCategorias"] = new SelectList(listadoDeCategorias, "id", "categoria");


            var listadoDeAutores = (from a in _LibreriaBDContext.autores
                                       select a).ToList();
            ViewData["listadoDeAutores"] = new SelectList(listadoDeAutores, "id", "autor");


            var listadoDeLibros = (from l in _LibreriaBDContext.libros
                                   join ca in _LibreriaBDContext.categorias on l.id_categoria equals ca.id
                                   join a in _LibreriaBDContext.autores on l.id_autor equals a.id
                                   select new
                                     {
                                         id = l.id,
                                         nombre = l.nombre,
                                         descripcion = l.descripcion,
                                         url_imagen = l.url_imagen,
                                         id_autor = a.autor,
                                         id_categoria = ca.categoria,
                                         precio = l.precio,
                                         estado = l.estado

                                     }).ToList();
            ViewData["listadoDeLibros"] = listadoDeLibros;

            return View();
        }
    }
}
