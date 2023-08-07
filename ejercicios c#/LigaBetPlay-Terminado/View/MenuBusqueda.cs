
namespace LigaBetPlay.View;
 
public class MenuBusqueda
{

    public MenuBusqueda() { }

    public int ConsultaDatos()
    {
        Console.Clear();
        Console.WriteLine("\n------------------- Consulta de Datos ------------------:");
        Console.WriteLine("1. Buscar Equipo");
        Console.WriteLine("2. Listar Jugadores por Equipo");
        Console.WriteLine("3. Buscar los delanteros de cada equipo");
        Console.WriteLine("4. Buscar cuerpo entrenadores por equipo");
        Console.WriteLine("5. Volver al Menù Principal");
        return Convert.ToInt32(Console.ReadLine()); 

    }
}
