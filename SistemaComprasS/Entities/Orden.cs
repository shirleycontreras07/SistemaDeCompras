using System;

namespace SistemaComprasS.Entities
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public int Solicitud { get; set; }
        public string Fecha { get; set; }
        public int Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Medida { get; set; }
        public int Marca { get; set; }
        public Decimal Costo { get; set; }
        public bool Estado { get; set; }
    }
}