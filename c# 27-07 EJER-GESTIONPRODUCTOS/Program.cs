using System;
using System.Collections.Generic;

class Program{
    public static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

    static void Main()
    
    {
        int opcion;

        do
        {
            menu();
            opcion = pedirOpcion();

            switch (opcion)
            {
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
            }

        } while (opcion != 5);
    }

    static void menu()
    {
        Console.WriteLine("\n---------------------------------- Sistema gestion de productos ----------------------------------\n");
        Console.WriteLine("1. AGREGAR PRODUCTO");
        Console.WriteLine("2. DETALLES DEL PRODUCTO");
        Console.WriteLine("3. LISTA DE PRODUCTOS");
        Console.WriteLine("4. ACTUALIZAR PRODUCTO");
        Console.WriteLine("5. SALIR");
    }

    static int pedirOpcion()
    {
        Console.WriteLine("\n\nELIGE UNA OPCIÓN: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        return respuesta;
    }

    static void agregar()
    {
        Console.Clear();
        Console.WriteLine("\nIngresa el id del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIngresa el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nIngresa el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nIngresa la cantidad de este producto en el inventario: ");
        int inventario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIngresa los compradores de este producto (separa cada comprador por una coma): ");
        string compradoresInput = Console.ReadLine();
        string[] compradores = compradoresInput.Split(',');

        Producto nuevoProducto = new Producto(id, nombre, precio, inventario, new List<string>());

        foreach (string comprador in compradores)
        {
            nuevoProducto.Clientes.Add(comprador.Trim());
        }

        productos.Add(id, nuevoProducto);
        Console.Clear();
    }

    static void detallesProducto()
    {
        Console.Clear();
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

    static void listaProducto()
    {
        Console.Clear();
        foreach (KeyValuePair<int, Producto> producto in productos)
        {
            Console.WriteLine($"ID: {producto.Key}  NOMBRE: {producto.Value.Nombre}  PRECIO: {producto.Value.Precio}  CANTIDAD EN INVENTARIO: {producto.Value.CantidadInventario}  CLIENTES: {string.Join(", ", producto.Value.Clientes)}");
        }
    }

    static void menuu()
    {
        Console.Clear();
        Console.WriteLine("\n---------------------------------- Actualiza tu producto ----------------------------------\n");
        Console.WriteLine("1. ACTUALIZAR PRECIO DEL PRODUCTO");
        Console.WriteLine("2. ACTUALIZAR CANTIDAD DEL PRODUCTO");
        Console.WriteLine("3. ACTUALIZAR LOS CLIENTES DEL PRODUCTO");
        Console.WriteLine("4. VOLVER AL MENU PRINCIPAL");
    }

    static void actualizarProducto()
    {
        int oopcion;

        do
        {
            menuu();
            oopcion = peedirOpcion();

            switch (oopcion)
            {
                case 1:
                    actualizarPrecioProduct();
                    break;

                case 2:
                    actualizarCantidadProduct();
                    break;

                case 3:
                    actualizarListadoProduct();
                    break;

                case 4:
                    Main();
                    break;
            }

        } while (oopcion != 4);
    }

    static int peedirOpcion()
    {
        Console.WriteLine("\nELIGE UNA OPCIÓN: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        return respuesta;
    }

    static void actualizarPrecioProduct()
    {
        Console.Clear();
        Console.WriteLine("Ingresa la identificación del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (productos.ContainsKey(id))
        {
            Console.WriteLine("Ingresa el nuevo precio del producto: ");
            double nuevoPrecio = Convert.ToDouble(Console.ReadLine());
            productos[id].Precio = nuevoPrecio;
            Console.WriteLine("Precio actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Este producto no existe!");
        }
    }

    static void actualizarCantidadProduct()
    {
        Console.Clear();
        Console.WriteLine("Ingresa la identificación del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (productos.ContainsKey(id))
        {
            Console.WriteLine("Ingresa la nueva cantidad del producto en inventario: ");
            int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
            productos[id].CantidadInventario = nuevaCantidad;
            Console.WriteLine("Cantidad actualizada correctamente.");
        }
        else
        {
            Console.WriteLine("Este producto no existe!");
        }
    }

    static void actualizarListadoProduct()
    {
        Console.Clear();
        Console.WriteLine("Ingresa la identificación del producto: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (productos.ContainsKey(id))
        {
            Console.WriteLine("Ingresa los nuevos clientes del producto (separa cada cliente por una coma): ");
            string compradoresInput = Console.ReadLine();
            string[] compradores = compradoresInput.Split(',');

            productos[id].Clientes.Clear();

            foreach (string comprador in compradores)
            {
                productos[id].Clientes.Add(comprador.Trim());
            }

            Console.WriteLine("Clientes actualizados correctamente.");
        }
        else
        {
            Console.WriteLine("Este producto no existe!");
        }
    }
}