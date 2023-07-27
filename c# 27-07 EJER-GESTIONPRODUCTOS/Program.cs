public class Producto{
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public double Precio { get; set; }
    public int CantidadInventario { get; set; }

    public List<string> Clientes { get; set; }

    public static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

    public Producto (int id, string nombre, double precio, int cantidadInventario, List<string> clientes){
        Nombre = nombre;
        Precio = precio;
        CantidadInventario = cantidadInventario;
        Clientes = clientes;
    }

    static void Main(){
        int opcion;

        do {
            menu();
            opcion = pedirOpcion();

            switch (opcion) {
                case 1:
                    agregar();
                    break;

                case 2:
                    detallesProducto();
                    break;

                case 3:
                    listaProducto();
                    break;

                case 4:
                    actualizarProducto();
                    break;

                case 5:
                    break;                
            };

        } while (opcion != 5);
    }

    static void menu(){
        Console.WriteLine("\n---------------------------------- Sistema gestion de productos ----------------------------------\n");
        Console.WriteLine("1. AGREGAR PRODUCTO");
        Console.WriteLine("2. DETALLES DEL PRODUCTO");
        Console.WriteLine("3. LISTA DE PRODUCTOS");
        Console.WriteLine("4. ACTUALIZAR PRODCUTO");
        Console.WriteLine("5. SALIR");
    }

    static int pedirOpcion(){
        Console.WriteLine("\nELIGE UNA OPCIÓN: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        return respuesta;
    }

    static void agregar(){
        Console.WriteLine("\nIngresa el id del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIngresa el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nIngresa el precio del producto: ");
        string precio = Console.ReadLine();
        Console.WriteLine("\nIngresa la cantidad de este producto en el inventario: ");
        string inventario = Console.ReadLine();
        Console.WriteLine("\nIngresa los compradores de este producto:          (separa cada producto por una coma) ");
        string compradoresInput = Console.ReadLine();
        string[] compradores = compradoresInput.Split(',');

        Producto nuevoProducto = new Producto
        {
            Nombre = nombre,
            Precio = precio,
            CantidadInventario = inventario
        };

        foreach (string comprador in compradores)
        {
            nuevoProducto.Hobbies.Add(producto.Trim());
        }

        productos.Add(id, nuevoProducto);
    }

    static void detallesProducto(){
        Console.WriteLine("Ingresa la identificación del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (productos.ContainsKey(id))
        {
            Producto producto = productos[id];
            Console.WriteLine($"ID: {id}  NOMBRE: {producto.Nombre}  PRECIO: {producto.Precio}  CANTIDAD EN INVENTARIO: {producto.CantidadInventario}  CLIENTES: {string.Join(", ", producto.Clientes)}");
        }
        else
        {
            Console.WriteLine("ESTE PRODUCTO NO EXISTE!");
        }
    }

    static void listaProducto(){
        foreach (KeyValuePair<int, Producto> producto in productos){
            Console.WriteLine($"ID: {producto.Key}  NOMBRE: {producto.Value.Nombre}  PRECIO: {producto.Value.Precio}  CANTIDAD EN INVENTARIO: {producto.Value.CantidadInventario}  CLIENTES: {string.Join(", ", producto.Value.Clientes)}");
        }
    }
}
