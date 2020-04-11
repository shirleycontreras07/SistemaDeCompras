namespace SistemaComprasS.Entities
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Departamento { get; set; }
        public bool Estado { get; set; }
    }
}