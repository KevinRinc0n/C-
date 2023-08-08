namespace ejercicioAutomotriz.menus;

public class MainMenu
{
    public MainMenu() { }

    public int mostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------ CENTRO AUTOMOTRIZ ------------------------------------");
        Console.WriteLine("             ----------------------- Que deseas realizar? -----------------------");
        Console.WriteLine("\n1. Crear orden");
        Console.WriteLine("2. Agregar");
        Console.WriteLine("3. Factura");
        Console.WriteLine("4. Salir");
        Console.Write("\nIngresa la opcion que deseas realizar: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}