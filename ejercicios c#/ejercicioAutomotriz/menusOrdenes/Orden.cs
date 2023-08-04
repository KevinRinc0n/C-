namespace ejercicioAutomotriz.menusOrdenes
{
    public class Orden : Persona
    {
        int numeroOrden {get; set; }

        public Orden(int numeroOrden, int idCliente, int fechaOrden, string nombreCliente):base(id, fechaRegistro, nombre)
        {
            this.numeroOrden = numeroOrden;
            this.id = idCliente;
            this.fechaRegistro = fechaOrden;
            this.nombre = nombreCliente;
        }

        public void mostrarOrden()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------- DATOS DE LA ORDEN ----------------------------");
            Console.WriteLine($"         Nro Orden: {}                            Fecha orden: {}");
            Console.WriteLine($"         Id cliente: {}                           Nombre cliente: {}");
            Console.WriteLine("--------------------------- DATOS DEL VEHICULO ----------------------------");
            Console.WriteLine($"         Nro placa: {}                            Kilometraje: {}");
            Console.WriteLine("--------------------------- DIAGNOSTICO CLIENTE ----------------------------");
            Console.WriteLine("--------------------------- INGRESAR EL DIAGNOSTICO ----------------------------");
            Console.WriteLine("--------------------------- PERSONAL A CARGO ----------------------------");
            Console.WriteLine($"         Nro cedula: {}            Nombre: {}                Especialidad: {}");
        }
    }
}