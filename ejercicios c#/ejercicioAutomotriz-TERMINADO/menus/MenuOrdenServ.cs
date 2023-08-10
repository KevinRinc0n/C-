namespace CRA.menus;

public class MenuOrdenServ 
{
    public MenuOrdenServ(){}

    public int MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\n--------------- Orden de servicio ----------------");
        Console.WriteLine($"1. Registrar");
        Console.WriteLine($"2. Consultar Órdenes de Servicio de cada cliente");
        Console.WriteLine($"3. Añadir personal");
        Console.WriteLine($"4. Ver ordenes de aprobación");
        Console.WriteLine("5. Volver al menú principal");
        return Convert.ToInt32(Console.ReadLine());
    }
}
