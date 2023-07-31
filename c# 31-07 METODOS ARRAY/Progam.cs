internal class Program
{
    private static void Main (string[] args)
    {  
        List<string> Materias = new List<string>();
        Materias.Add("MATEMATICAS");
        Materias.Add("FISICA");
        Materias.Add("QUIMICA");
        Materias.Add("INGLES");

        Console.WriteLine("Total de elementos de la lista de materias: {0}", Materias.Count());

        Console.WriteLine("Capacidad total: {0}", Materias.Capacity);

        Console.WriteLine("Materias[3]: {0}", Materias[3]);
    }
}