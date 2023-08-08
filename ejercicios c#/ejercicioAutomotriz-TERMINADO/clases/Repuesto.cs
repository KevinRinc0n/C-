namespace ejercicioAutomotriz.clases
{
    public class Repuesto : Empleados
    {
        public string item { get; set;}
        public string nombre { get; set;}
        public long valor {get; set;}
        public int cantidad {get; set;}
        public string estado {get; set;}


        public Repuesto(string item, string nombre, long valor, int cantidad, string estado)
        {
            this.item = item;
            this.nombre = nombre;
            this.valor = valor;
            this.cantidad = cantidad;
            this.estado = estado;
        }

        public Repuesto () {}

        public Repuesto repuestoAgregar()
        {
            Console.Clear();
            Repuesto repuestoNuevo = new Repuesto();
            Console.Write("Ingresa el nombre del repuesto: ");
            repuestoNuevo.item = Console.ReadLine();
            Console.Write("Ingresa para que parte del vehiculo es el repuesto: ");
            repuestoNuevo.nombre = Console.ReadLine();
            Console.Write("Ingresa el valor del repuesto: ");
            repuestoNuevo.valor = long.Parse(Console.ReadLine());
            Console.Write("Ingresa la cantidad de este repuesto: ");
            repuestoNuevo.cantidad = int.Parse(Console.ReadLine());
            return repuestoNuevo;
        }

        public void mostrarRepuesto(List<Repuesto> Repuestoss)
        {
            Console.Clear();
            Console.WriteLine("REPUESTO\t\tValor");
            foreach (var repuesto in Repuestoss)
            {
                Console.WriteLine($"{repuesto.item}\t\t{repuesto.valor}");
            }
            Console.ReadKey();  
        }

        public Repuesto aceptarRepuesto(List<Repuesto> Repuestoss)
        {
            Console.Clear();
            mostrarRepuesto(Repuestoss);
            Console.WriteLine("PON 'A' PARA ACEPTAR EL REPUESTO O 'R' PARA RECHAZARLO ");

            Repuesto repuestoSeleccionado = null;

            foreach (var repuesto in Repuestoss)
            {
                Console.WriteLine($"Este repuesto es: {repuesto.item}");
                string opcion = Console.ReadLine();

                if (opcion.ToUpper() == "A")
                {
                    repuesto.estado = "A";
                    repuestoSeleccionado = repuesto;
                    break;
                }
                else if (opcion.ToUpper() == "R")
                {
                    repuesto.estado = "R";
                    repuestoSeleccionado = repuesto;
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Introduce 'A' o 'R'");
                }
            }
            return repuestoSeleccionado;
        }
    }
}