namespace ejercicio_Tienda.clases
{
    public class Categoria
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public Categoria (int id, string descripcion)
    {
        this.id = id;
        this.descripcion = descripcion;
    }

    public Categoria () {}

    public Categoria agregarCategorias()
    {
        Console.Clear();
        Categoria categoria = new Categoria();
        Console.WriteLine("AGREGAR UNA CATEGORIA");
        Console.Write("Ingresa el id de la categoria: ");
        categoria.id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el nombre de la categoria: ");
        categoria.descripcion = Console.ReadLine();
        return categoria;
        Console.ReadKey();
    }
}