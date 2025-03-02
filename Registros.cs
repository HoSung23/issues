namespace BlazorApp1.Data.Models
{
    public class Registros
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Asunto { get; set; }
        public required string Cliente { get; set; }
        public required string DescCorta { get; set; }
        public required string Descripcion { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Nota { get; set; } = string.Empty;
    }
}
