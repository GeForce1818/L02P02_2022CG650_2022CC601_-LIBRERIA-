namespace L02P02_2022CG650_2022CC601.Models
{
    public class pedido_encabezado
    {
        public int id { get; set; }

        public int id_cliente { get; set; }
        public clientes Clientes { get; set; }

        public int cantidad_libros { get; set; }
        public decimal total { get; set; }
    }
}
