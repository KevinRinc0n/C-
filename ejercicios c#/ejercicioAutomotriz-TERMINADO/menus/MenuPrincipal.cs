namespace CRA.menus;

public class MenuPrincipal 
{
    public MenuPrincipal() { }

    public int MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\n--------------- Centro Automotríz ----------------");
        Console.WriteLine($"1. Registrar");
        Console.WriteLine("2. Ordenes de Servicio");
        Console.WriteLine("3. Facturación");
        Console.WriteLine("4. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }
}
