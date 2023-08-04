namespace ejercicioAutomotriz.clases
{
    List<Empleado> Empleadoss = new List<Empleado>(); 
    public class Empleados : Persona
    {
        public string especialidad { get; set; }

        public Empleados (int id, string nombre, string apellido, int numero, string especialidad):base(id,nombre,apellido,numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
            this.especialidad = especialidad;
        }

        public void agregarEmpleado(List<Empleado> Empleadoss)
        {
            Console.Write("Ingresa la cedula del empleado: ");
            int cedula = Console.ReadLine();
            Console.Write("Ingresa el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa el apellido del empleado: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingresa el numero del empleado: ");
            string numero = Console.ReadLine();
            Console.Write("Ingresa la especialidad del empleado: ");
            string especialidad = Console.ReadLine();
            Empleados empleado = new Empleados(cedula, nombre, apellido, numero, especialidad);
            Empleadoss.Add(empleado);
        }   

        public void mostrarEmpleados(List<Empleado> Empleadoss)
        {
            foreach(empleado in Empleadoss)
            {
                Console.WriteLine("CEDULA\t\tNOMBRE\t\tAPELLIDO\t\tNUMERO\t\tESPECIALIDAD");
                Console.WriteLine($"{empleado.cedula}\t\t{empleado.nombre}\t\t{empleado.apellido}\t\t{empleado.numero}\t\t{empleado.especialidad}");
            }
        }
    }
}