namespace ejercicio_Tienda.clases
{
    public static class Json
    {
        private static string filaName = "productos.json";
        private static List<Producto> productos = new List<Producto>();

        public static string FileName { get => filaName; set => filaName = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }
    }
}