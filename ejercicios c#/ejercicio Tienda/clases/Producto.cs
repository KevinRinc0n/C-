namespace ejercicio_Tienda.clases
{
    public class Producto
    {
        public int codigo { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public int stockMin { get; set; }
        public int stockMax { get; set; }
        public double precioVenta { get; set; }
        public double precioCompra { get; set; }
    }

    public Producto ()
    {
        if (!File.Exists (Json.FileName)){
            File.WriteAllText (Json.FileName),"";
        }
    }

    public Producto(int codigo, int idCategoria, string nombre, int stock, int stockMin, int stockMax, double precioVenta, double precioCompra)
    {
        this.codigo = codigo;
        this.idCategoria = idCategoria;
        this.nombre = nombre;
        this.stock = stock;
        this.stockMin = stockMin;
        this.stockMax = stockMax;
        this.precioVenta = precioVenta;
        this.precioCompra = precioCompra;
    }

    public Producto () {}

    public Producto agregarProductos()
    {
        Console.Clear();
        Producto producto = new Producto();
        Console.WriteLine("AGREGAR EL PRODUCTO");
        Console.Write("Ingresa el codigo del producto: ");
        producto.codigo = Conver.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el nombre del producto: ");
        producto.nombre = Console.ReadLine();
        Console.Write("Ingresa la cantidad que hay en stock del producto: ");
        producto.stock = Conver.ToInt32(Console.ReadLine());
        Console.Write("Ingresa la cantidad minima que puede haber en stock del producto: ");
        producto.stockMin = Conver.ToInt32(Console.ReadLine());
        Console.Write("Ingresa la cantidad maxima que puede haber en stock del producto: ");
        producto.stockMax = Conver.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el precio de compra del producto: ");
        producto.precioCompra = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el precio de venta del producto: ");
        producto.precioVenta = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el id de la categoria a la que pertenece el producto: ");
        producto.idCategoria = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nPRODUCTO AGREGADO CORRECTAMENTE");
        return producto;
        Console.ReadKey();
    }
}