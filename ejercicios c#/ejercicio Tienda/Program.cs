using ejercicio_Tienda.menus;
using ejercicio_Tienda.clases;

internal class Program 
{
    private static void Main(string[] args)
    {
        MenuPrincipal menuPrincipal = new MenuPrincipal();
        int opcion;

        do
        {
            opcion = menuPrincipal.mostrarMenuPrincipal();

            switch (opcion)
            {   
                case 1:
                    Producto productoAgregar = new Producto();
                    productoAgregar = productoAgregar.agregarProductos();
                    break;

                case 2:     
                    Categoria categoriaAgregar = new Categoria();    
                    categoriaAgregar = categoriaAgregar.agregarCategoria();
                    break;
                case 6:
                    Console.WriteLine("ADIOS !!!");
                    break;
                default:
                    Console.WriteLine("OPCIÓN INVALIDA");
                    break;    
            }
        } while (opcion != 6);
    }
}