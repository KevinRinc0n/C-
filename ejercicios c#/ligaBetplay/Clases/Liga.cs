namespace ligaBetplay.Clases
{
    public class Liga
    {
        private int id {get; set;}
        public string  nombre {get; set;}

        private List<Equipo> equipos  = new List<Equipo> ();

        public Liga(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public List<Equipo> EquiposDeLiga
        {
            get { return this.equiposDeLiga; }
            set { this.equiposDeLiga = value; }
        }

        public Liga(){}
        public void agregarLiga (List<Liga> Ligas)
        {
            Console.WriteLine("Agregar Liga");
            Console.Write("Ingrese el Nombre de la Liga:");
            string nombreLiga = Console.ReadLine();
            Console.Write("Ingrese el Id de la Liga:");
            int idLiga= int.Parse(Console.ReadLine());
            Liga liga = new Liga(nombreLiga,idLiga);
            Ligas.Add(liga);
        }

        public void mostrarLigas(List<Liga> Ligas)
        {
            Console.Clear();
            Console.WriteLine("Id\tNombre");
            foreach (var liga in Ligas)
            {
                Console.WriteLine($"{liga.id}\t{liga.nombre}");
            }
            Console.ReadKey();
        }

        public Liga agregarLiga ()
        {
            Liga liga = new Liga();

            Console.Write("Ingrese el Id de la Liga:");
            liga.id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el Nombre de la Liga:");
            liga.nombre = Console.ReadLine();

            return liga;
        }

        public Liga buscarLiga(List<Liga> Ligas){

            mostrarLigas(Ligas);

            Console.WriteLine("ingrese el id de la liga: ");
            int opcion = int.Parse(Console.ReadLine());

            return Ligas.Find( e => e.id == opcion );
        }
    }
}