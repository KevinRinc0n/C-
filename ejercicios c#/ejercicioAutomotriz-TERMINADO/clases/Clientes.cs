namespace ejercicioAutomotriz.clases
{
    public class Clientes : Persona 
    {
        public string email { get; set; }
        public string fechaRegistro { get; set; }
        public List<Clientes> Clients { get; set; }
        public List<Vehiculos> Vehiculoss { get; set; }

        public Clientes(long id, string nombre, string apellido, long numero, string email, string fechaRegistro) : base(id, nombre, apellido, numero)
        {
            this.Clients = new List<Clientes>();
            this.Vehiculoss = new List<Vehiculos>();
            this.email = email;
            this.fechaRegistro = fechaRegistro;
        }

        public Clientes ()
        {
            this.Clients = new List<Clientes>();
            this.Vehiculoss = new List<Vehiculos>();
        }

        public Clientes agregarCliente()
        {
            Console.Clear();
            Clientes Cliente = new Clientes();
            Console.Write("\nIngresa la cedula del cliente: ");
            Cliente.id = long.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del cliente: ");
            Cliente.nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ");
            Cliente.apellido = Console.ReadLine();
            Console.Write("Ingrese el número del cliente: ");
            Cliente.numero = long.Parse(Console.ReadLine());
            Console.Write("Ingrese el email del cliente: ");
            Cliente.email = Console.ReadLine();
            Console.Write("Ingrese la fecha del registro del cliente: ");
            Cliente.fechaRegistro = Console.ReadLine();
            return Cliente;
        }

        public void mostrarClientes(List<Clientes> Clients)
        {
            Console.WriteLine("\nCEDULA\t\tNOMBRE\t\tAPELLIDO\tNUMERO\t\tEMAIL\t\tFECHA DE REGISTRO");
            foreach(var cliente in Clients)
            {
                Console.WriteLine($"{cliente.id}\t\t{cliente.nombre}\t\t{cliente.apellido}\t\t{cliente.numero}\t\t{cliente.email}\t\t{cliente.fechaRegistro}");
            }
            Console.ReadKey();
        }

        public Clientes buscarCliente(List<Clientes> Clients)
        {
            mostrarClientes(Clients);
            Console.Write("\nIngresa la cedula del cliente: ");
            long opcion = long.Parse(Console.ReadLine());
            return Clients.Find(cliente => cliente.id == opcion);
        }
    }
}