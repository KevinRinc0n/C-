namespace ejercicioAutomotriz.menus;

public class MenuAgregar 
{
    public MenuAgregar() { }

    public int mostrarMenuAgregar()
    {
        Console.Clear();
        Console.WriteLine("----------------------------- Que deseas agregar? -----------------------------");
        Console.WriteLine("1. Cliente");
        Console.WriteLine("2. Vehiculo");
        Console.WriteLine("3. Empleado");
        Console.WriteLine("4. Repuestos");
        Console.WriteLine("5. Regresar al menu principal");
        Console.Write("\nIngresa la opcion que deseas realizar: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}