namespace SistemaComprasS.Entities
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int Empleado { get; set; }
        public string Fecha { get; set; }
        public int Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Medida { get; set; }
        public bool Estado { get; set; }
    }
}