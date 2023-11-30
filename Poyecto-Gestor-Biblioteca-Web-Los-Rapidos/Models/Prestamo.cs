namespace Poyecto_Gestor_Biblioteca_Web_Los_Rapidos.Models
{
    public class Prestamo
    {
        public string Libro { get; set; }
        public string Usuario { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string FechaEntrega { get; set; }
        public string Estado { get; set; }

    }
}
