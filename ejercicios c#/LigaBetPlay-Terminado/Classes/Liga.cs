namespace LigaBetPlay.Classes;

class Liga
{
    public string nombre { get; set; }
    private int id;
    private List<Equipo> equiposDeLiga = new List<Equipo>();
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


    public Liga(string nombre, int id)
    {
        this.nombre = nombre;
        this.Id = id;
    }

    public Liga(){ }

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

    public Liga agregarLiga()
    {
        Liga liga = new Liga();

        Console.Write("Ingrese el Id de la Liga:");
        liga.id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Nombre de la Liga:");
        liga.nombre = Console.ReadLine();

        return liga;
    }

    public Liga buscarLiga(List<Liga> Ligas)
    {
        mostrarLigas(Ligas);
        Console.WriteLine("ingrese el id de la liga: ");
        int opcion = int.Parse(Console.ReadLine());
        return Ligas.Find(liga => liga.id == opcion);
    }


}

