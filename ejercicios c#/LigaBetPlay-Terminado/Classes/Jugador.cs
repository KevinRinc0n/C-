
namespace LigaBetPlay.Classes;

public class Jugador : Persona
{
    public int Dorsal {get;set;}
    public string Posicion {get;set;}
    public int NivelHabilidad {get;set;}
    public string PiernaHabil {get;set;}

    public Jugador (string nombre, int edad, int id,string ciudadOrigen, int dorsal, string posicion, int nivelHabilidad, string PiernaHabil): base(nombre,edad,id, ciudadOrigen)
    {
        this.Dorsal = dorsal;
        this.Posicion =posicion;
        this.NivelHabilidad = nivelHabilidad;
        this.PiernaHabil = PiernaHabil;
    }

    public Jugador (){}
    public Jugador agregarJugador (){
        Jugador jugador = new Jugador();
        Console.Write("Ingrese el nombre del Jugador :");
        jugador.nombre = Console.ReadLine();
        
        Console.Write("Ingrese la edad del Jugador :");
        jugador.edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Id del Jugador :");
        jugador.id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la ciudad de origen del Jugador :");
        jugador.ciudadOrigen = Console.ReadLine();

        Console.Write("Ingrese el Dorsal del Jugador :");
        jugador.Dorsal = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la posicion del Jugador :");
        jugador.Posicion = Console.ReadLine();

        Console.Write("Ingrese el nivel de habilidad del Jugador :");
        jugador.NivelHabilidad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la Pierna Habil del Jugador :");
        jugador.PiernaHabil = Console.ReadLine();

        return jugador;
    } 
    
    public Jugador BuscarJugador(List<Jugador> jugadores)
    {
        Console.WriteLine("Nombre");
        foreach (var jugador in jugadores)
        {
        Console.WriteLine($"{jugador.nombre}");
        }
        Console.ReadKey();
        Console.WriteLine("ingrese el nombre del Jugador: ");
        string opcion = Console.ReadLine();
        Jugador jugadorSeleccionado = jugadores.Find(Jugador => Jugador.nombre.Equals(opcion));
        Console.ReadKey();
        return jugadorSeleccionado;
    }
}
