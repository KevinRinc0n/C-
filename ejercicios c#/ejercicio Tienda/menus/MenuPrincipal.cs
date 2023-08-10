namespace ejercicio_Tienda.menus
{
    public class MenuPrincipal
    {
        public MenuPrincipal () {}

        public int mostrarMenuPrincipal()
        {
            Console.WriteLine("------------------------------------------ SUPER TIENDA ABS ------------------------------------------");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Registrar Categoria");
            Console.WriteLine("3. Listar Categorias");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Costp total del inventario");
            Console.WriteLine("6. Salir");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}