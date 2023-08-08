namespace ejercicioAutomotriz.clases
{
    public class Vehiculos : Empleados
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double kilometraje { get; set; }
        public string diagnostico { get; set; }
        public List<Empleados> Empleadoss { get; set; }


        public Vehiculos(string placa, string modelo, string marca, string color, double kilometraje, string diagnostico)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.kilometraje = kilometraje;
            this.diagnostico = diagnostico;
            this.Empleadoss = new List<Empleados>();
        }

        public Vehiculos ()
        {
            this.Empleadoss = new List<Empleados>();
        }


        public Vehiculos agregarVehiculo()
        {
            Console.Clear();
            Vehiculos Vehiculo = new Vehiculos();
            Console.Write("\nIngresa la placa del vehiculo: ");
            Vehiculo.placa = Console.ReadLine();
            Console.Write("Ingresa el modelo del vehiculo: ");
            Vehiculo.modelo = Console.ReadLine();
            Console.Write("Ingresa la marca del vehiculo: ");
            Vehiculo.marca = Console.ReadLine();
            Console.Write("Ingresa el color del vehiculo: ");
            Vehiculo.color = Console.ReadLine(); 
            Console.Write("Ingresa el kilometraje del vehiculo: ");
            Vehiculo.kilometraje = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el diagnostico que da el cliente del vehiculo: ");
            Vehiculo.diagnostico = Console.ReadLine();
            return Vehiculo;
        }

        public void mostrarVehiculos(List<Vehiculos> Vehiculoss)
        {
            Console.Clear();
            Console.WriteLine("PLACA\t\tMODELO\t\tMARCA\t\tCOLOR\t\tKILOMETRAJE\tDIAGNOSTICO");
            foreach(var vehiculo in Vehiculoss)
            {
                Console.WriteLine($"{vehiculo.placa}\t\t{vehiculo.modelo}\t\t{vehiculo.marca}\t\t{vehiculo.color}\t\t{vehiculo.kilometraje}\t\t{vehiculo.diagnostico}");
            }
            Console.ReadKey();
        }

        public Vehiculos buscarVehiculos(List<Vehiculos> Vehiculoss)
        {
            mostrarVehiculos(Vehiculoss);
            Console.Write("\nIngresa la placa del vehiculo: ");
            string opcion = Console.ReadLine();
            return Vehiculoss.Find(vehiculo => vehiculo.placa.Equals(opcion));
        }
    }
}