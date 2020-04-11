namespace SistemaComprasS.Entities
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}