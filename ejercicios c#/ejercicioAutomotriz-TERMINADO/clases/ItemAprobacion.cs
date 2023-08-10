namespace CRA.clases;

public class ItemAprobacion
{ 
    public string Item { get; set; }
    public string Repuesto { get; set; }
    public double ValorUnitario { get; set; }
    public int Cantidad { get; set; }
    public double ValorTotal { get; private set; }
    public string Estatus { get; set; }

    public ItemAprobacion(string item, string repuesto, double valorUnitario, int cantidad)
    {
        this.Item = item;
        this.Repuesto = repuesto;
        this.ValorUnitario = valorUnitario;
        this.Cantidad = cantidad;
        this.Estatus = "R";
        this.ValorTotal = ValorUnitario * Cantidad;
    }
}
