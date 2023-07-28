using System;
using System.Collections.Generic;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int CantidadInventario { get; set; }
    public List<string> Clientes { get; set; }


    public Producto(int id, string nombre, double precio, int cantidadInventario, List<string> clientes)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        CantidadInventario = cantidadInventario;
        Clientes = clientes;
    }

    public void actualizarPrecioProduct(double newPrecio){
        Precio = newPrecio;
    }

    public void actualizarCantidadProduct(int newCantidad){
        CantidadInventario = newCantidad;
    }

    public void actualizarListadoProduct(List<string> newClientes){
        Clientes = newClientes;
    }
}