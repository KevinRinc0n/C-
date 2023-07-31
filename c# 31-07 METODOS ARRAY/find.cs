internal class Programm
{
    private static void Main (string[] args)
    {  
        String ? palabra;
        List<string> Dinosaurios = new List<string>();
        string [] Dinos = {"Brachiosaurus",
                            "Amargasaurus",
                            "T-rex"};

        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Ingresa el nombre del dinosaurio a buscar: ");

        palabra = Console.ReadLine();

        Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "Se encontro el dinosaurio" : "No se encontro el dinosaurio");
    }
}