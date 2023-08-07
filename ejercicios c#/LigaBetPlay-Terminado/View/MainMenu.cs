
namespace LigaBetPlay.View;

public class MainMenu
{
    public MainMenu() { }

    public int MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\n--------------- Liga BetPlay ----------------");
        Console.WriteLine($"1. Registrar Plantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Registrar Liga");
        Console.WriteLine("4. Salir");
        return Convert.ToInt32(Console.ReadLine());

    }
}
