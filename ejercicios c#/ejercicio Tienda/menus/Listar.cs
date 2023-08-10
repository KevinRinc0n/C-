namespace ejercicio_Tienda.menus
public class Listar
{
    public Listar( ) {}

    public void listarCategorias()
    {
        Console.Clear();
        Console.WriteLine("LISTADO DE CATEGORIAS");
        Console.WriteLine("{0, -29} {1,10}","ID", "NOMBRE");
        foreach (categoria in categorias)
        {
            Console.WriteLine("{0, -32} {1,7}",categoria.id, categoria.descripcion);
        }
        Console.ReadKey();
    }

    public void listarProductos()
    {
        Console.Clear();
        Console.WriteLine("LISTADO DE PRODUCTOS");
        Console.WriteLine("{0, -29} {1,10} {2,10}","ID", "NOMBRE", "STOCK");
        foreach (producto in productos)
        {
            Console.WriteLine("{0, -32} {1,7}",producto.codigo, producto.nombre, producto.stock);
        }
        Console.ReadKey(); 
    }

    public void totalInventario()
    {
        Console.Clear();
        Console.WriteLine("VALOR DEL INVENTARIO");
        Console.WriteLine("{0, -29} {1,10} {2,10} {3,10} {4,10}", "");

    }
}
