internal class Programmm
{
    private static void Main (string[] args)
    {  
       String ? palabra = null;

       List<string>Dinosaurios = new List<string>();
       List<string>Encontrados = new List<string>();

       string [] Dinos = {
                            "Brachiosaurus",
                            "Amargasaurus",
                            "T-rex"};

        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Escriba la letra o palabra que desea buscar: ");

        palabra = Console.ReadLine();

        Encontrados = Dinosaurios.FindAll(n => n.Contains(palabra ?? String.Empty));
        foreach(String n in Encontrados){
            Console.WriteLine(n);
        };
    }
}