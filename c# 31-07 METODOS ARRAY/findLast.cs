internal class Programmmm
{
    private static void Main (string[] args)
    {  
       String ? palabra = null;

       List<string>Dinosaurios = new List<string>();

       string [] Dinos = {
                            "Brachiosaurus",
                            "Amargasaurus",
                            "T-rex"};

        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Escriba la letra o palabra que desea buscar: ");

        palabra = Console.ReadLine();

        string ? ultimoEncontrado = Dinosaurios.FindLast(n => n.Contains(palabra ?? String.Empty));

        Console.WriteLine("El ultimo dinosaurio que contiene esa letra es: {0} ", ultimoEncontrado);
    }
}