namespace L02P02_2022CG650_2022CC601.Models
{
    public class comentarios_libros
    {
        public int id { get; set; }

        public int id_libro { get; set; }
        public libros Libro { get; set; }

        public string? comentarios { get; set; }
        public string? usuario { get; set; }
        public DateTime created_at { get; set; }
    }
}
