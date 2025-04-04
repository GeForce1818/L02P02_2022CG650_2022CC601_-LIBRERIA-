﻿using Microsoft.EntityFrameworkCore;

namespace L02P02_2022CG650_2022CC601.Models
{
    public class LibreriaBDContext : DbContext
    {
        public LibreriaBDContext(DbContextOptions<LibreriaBDContext> options) : base(options)
        { }

        public DbSet<autores> autores { get; set; }
        public DbSet<categorias> categorias { get; set; }
        public DbSet<clientes> clientes { get; set; }

        public DbSet<comentarios_libros> comentarios_Libros { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<pedido_detalle> pedido_detalles { get; set; }
        public DbSet<pedido_encabezado> pedido_encabezado { get; set; }
    }
    
}
