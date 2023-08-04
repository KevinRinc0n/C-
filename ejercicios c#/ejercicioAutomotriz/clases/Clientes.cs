namespace ejercicioAutomotriz.clases
{
    List<Cliente> Clients = new List<Cliente>(); 

    public class Clientes : Persona 
    {
        public string email {get; set;}
        public string fechaRegistro {get; set;}

        public Persona (int id, string nombre, string apellido, int numero, string email, string fechaRegistro):base(id, nombre, apellido, numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
            this.email = email;
            this.fechaRegistro = fechaRegistro;
        }

        public void agregarCliente(List<Cliente> Clients)
        {
            Console.Write("Ingresa la cedula del cliente: ");
            int cedula = Console.ReadLine();
            Console.Write("Ingrese el nombre del cliente: ")
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ")
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el número del cliente: ")
            int numero = Console.ReadLine();
            Console.Write("Ingrese el email del cliente: ")
            string email = Console.ReadLine();
            Console.Write("Ingrese la fecha del registro del cliente: ")
            string fechaRegistro = Console.ReadLine();
            Clientes cliente = new Clientes(cedula, nombre, apellido, numero, email, fechaRegistro);
            Clients.Add(cliente);
        }

        public void mostrarClientes(List<Cliente> Clients)
        {
            foreach(cliente in Clients)
            {
                Console.WriteLine("CEDULA\t\tNOMBRE\t\tAPELLIDO\t\tNUMERO\t\tEMAIL\t\tFECHA DE REGISTRO");
                Console.WriteLine($"{cliente.cedula}\t\t{cliente.nombre}\t\t{cliente.apellido}\t\t{cliente.numero}\t\t{cliente.email}\t\t{cliente.fechaRegistro}");
            }
        }
    }
}