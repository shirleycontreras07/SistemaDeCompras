namespace SistemaComprasS.Entities
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public int Medida { get; set; }
        public int Existencia { get; set; }
        public bool Estado { get; set; }
    }
}