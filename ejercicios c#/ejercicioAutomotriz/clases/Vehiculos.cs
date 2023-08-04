namespace ejercicioAutomotriz.clases
{
    List<Vehiculo> Vehiculoss = new List<Vehiculo>(); 
    public class Vehiculos : Persona
    {
        string placa { get; set; }
        string color { get; set; }
        double kilometraje { get; set; }

        public Vehiculos (string placa, string modelo, string, marca, string color, double kilometraje):base(nombre, apellido)
        {
            this.placa = placa;
            this.nombre = modelo;
            this.apellido = marca;
            this.color = color;
            this.kilometraje = kilometraje;
        }

        public void agregarVehiculo(List<Vehiculo> Vehiculoss)
        {
            Console.Write("Ingresa la placa del vehiculo: ");
            string placa = Console.ReadLine();
            Console.Write("Ingresa el modelo del vehiculo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ingresa la marca del vehiculo: ");
            string marca = Console.ReadLine();
            Console.Write("Ingresa el color del vehiculo: ");
            string color = Console.ReadLine(); 
            Console.Write("Ingresa el kilometraje del vehiculo: ");
            double kilometraje = Console.ReadLine();
            Vehiculos vehiculo = new Vehiculos(placa, modelo, marca, color, kilometraje);
            Vehiculoss.Add(vehiculo);
        }

        public void mostrarVehiculos(List<Vehiculo> Vehiculoss)
        {
            foreach(vehiculo in Vehiculoss)
            {
                Console.WriteLine("PLACA\t\tMODELO\t\tMARCA\t\tCOLOR\t\tKILOMETRAJE");
                Console.WriteLine($"{vehiculo.placa}\t\t{vehiculo.modelo}\t\t{vehiculo.marca}\t\t{vehiculo.color}\t\t{vehiculo.kilometraje}");
            }
        }
    }
}