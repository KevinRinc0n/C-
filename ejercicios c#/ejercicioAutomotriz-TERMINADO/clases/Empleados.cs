namespace ejercicioAutomotriz.clases
{
    public class Empleados : Persona 
    {
        public string especialidad { get; set; }
        public string diagnostico { get; set; }
        public List<Repuesto> Repuestoss { get; set; }

        public Empleados(long id, string nombre, string apellido, long numero, string especialidad, string diagnostico) : base(id, nombre, apellido, numero)
        {
            this.especialidad = especialidad;
            this.diagnostico = diagnostico;
            this.Repuestoss = new List<Repuesto>();
        }

        public Empleados ()
        {
            this.Repuestoss = new List<Repuesto>();
        }

        public Empleados agregarEmpleado()
        {
            Console.Clear();
            Empleados Empleado = new Empleados();
            Console.Write("Ingresa la cedula del empleado: ");
            Empleado.id = long.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre del empleado: ");
            Empleado.nombre = Console.ReadLine();
            Console.Write("Ingresa el apellido del empleado: ");
            Empleado.apellido = Console.ReadLine();
            Console.Write("Ingresa el numero del empleado: ");
            Empleado.numero = long.Parse(Console.ReadLine());
            Console.Write("Ingresa la especialidad del empleado: ");
            Empleado.especialidad = Console.ReadLine();
            Console.Write("Ingresa el diagnostico del empleado: ");
            Empleado.diagnostico = Console.ReadLine();
            return Empleado;
        }   

        public void mostrarEmpleados(List<Empleados> Empleadoss)
        {
            Console.Clear();
            Console.WriteLine("CEDULA\t\tNOMBRE\t\tAPELLIDO\tNUMERO\t\tESPECIALIDAD\tDIAGNOSTICO");
            foreach(var empleado in Empleadoss)
            {
                Console.WriteLine($"{empleado.id}\t\t{empleado.nombre}\t\t{empleado.apellido}\t\t{empleado.numero}\t\t{empleado.especialidad}\t\t{empleado.diagnostico}");
            }
            Console.ReadKey();  
        }

        public Empleados buscarEmpleado(List<Empleados> Empleadoss)
        {
            mostrarEmpleados(Empleadoss);
            Console.Write("\nIngresa la cedula del empleado: ");
            long opcion = long.Parse(Console.ReadLine());
            return Empleadoss.Find(empleado => empleado.id == opcion); 
        }
    }
}