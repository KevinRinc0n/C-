int [] filas = {1,2,3,4,5,6,7,8};
string [] columnas = {"a", "b", "c", "d", "e", "f", "g", "h"};

int [] movimientosFilas = {2, 2, -2, -2, 1, -1, 1, -1};
int [] movimientosColumnas = {1, -1, 1, -1, 2, 2, -2, -2};

Console.WriteLine("Ingresa la fila en la que se encuentra el caballo: ");
int fila = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa la columna en la que se encuentra el caballo: ");
string ? columna = Console.ReadLine();

int posicionFila = Array.IndexOf(filas,fila);
int posicionColumna = Array.IndexOf(columnas,columna);

Console.WriteLine(posicionFila+" "+posicionColumna);

Console.WriteLine("Las posiciones a las que puede moverse el caballo son: ");

for (int i = 0; i < 8; i++){
    int newFila = posicionFila + movimientosFilas[i];
    int newColumna = posicionColumna + movimientosColumnas[i];

    if (newFila >= 0 && newFila < 8 && newColumna >= 0 && newColumna < 8){
        Console.WriteLine($"Fila: {filas[newFila]} Columna: {columnas[newColumna]}");
    }   
}
