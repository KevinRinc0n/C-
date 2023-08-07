namespace LigaBetPlay.View;

public class MenuPlantel
{
    public MenuPlantel() { } 

    public int menuPlantel()
    {
        Console.Clear();
        Console.WriteLine("\n----------------- Registro de Plantel -----------------");
        Console.WriteLine("1. Registro Equipo");
        Console.WriteLine("2. Registrar Entrenador");
        Console.WriteLine("3. Registrar Masajista");
        Console.WriteLine("4. Registrar Jugador");
        Console.WriteLine("5. Venta Jugador");
        Console.WriteLine("6. Volver al Menù Principal");
        return Convert.ToInt32(Console.ReadLine());
    }
}
