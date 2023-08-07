namespace LigaBetPlay.Classes;

class Masajista : Persona {
    public int añosDeExp { get; set; }
    public string titulacion { get; set; }

    public Masajista (string nombre, int id, int edad, string ciudadOrigen, int añosDeExp,string titulacion): base (nombre,id,edad,ciudadOrigen){
        this.añosDeExp = añosDeExp;
        this.titulacion = titulacion;
    } 

    public Masajista() { }

    public Masajista agregarMasajista()
    {
        Masajista Masajista = new Masajista();
        Console.Write("Ingrese el nombre del Masajista :");
        Masajista.nombre = Console.ReadLine();
        Console.Write("Ingrese la edad del Masajista :");
        Masajista.edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Id del Masajista :");
        Masajista.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la ciudad de origen del Masajista :");
        Masajista.ciudadOrigen = Console.ReadLine();
        Console.Write("Ingrese el años de experiencia del Masajista :");
        Masajista.añosDeExp = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la titulacion del Masajista :");
        Masajista.titulacion = Console.ReadLine();
        return Masajista;
    }
}
