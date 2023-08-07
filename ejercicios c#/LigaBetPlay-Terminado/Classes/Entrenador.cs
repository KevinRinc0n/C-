namespace LigaBetPlay.Classes;

class Entrenador : Persona {
    public int codFederacion { get; set; }
    public string especialidad { get; set; }

    public Entrenador (string nombre, int id, int edad, string ciudadOrigen, int codFederacion,string especialidad): base (nombre,id,edad,ciudadOrigen){
        this.codFederacion = codFederacion;
        this.especialidad = especialidad;
    }
    public Entrenador (){}

    public Entrenador agregarEntrenador() 
    {
        Entrenador entrenador = new Entrenador();
        Console.Write("Ingrese el nombre del entrenador :");
        entrenador.nombre = Console.ReadLine();
        Console.Write("Ingrese la edad del entrenador :");
        entrenador.edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Id del entrenador :");
        entrenador.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la ciudad de origen del entrenador :");
        entrenador.ciudadOrigen = Console.ReadLine();
        Console.Write("Ingrese el codFederacion del entrenador :");
        entrenador.codFederacion = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la especialidad del entrenador :");
        entrenador.especialidad = Console.ReadLine();
        return entrenador;
    }
}
