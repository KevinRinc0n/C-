namespace ligaBetplay.Menus;

    public class MenuPlantel
    {
        public double menuPlantel()
        {
            Console.Clear();
            Console.WriteLine("\n---------------------------------- REGISTRO PLANTEL ----------------------------------\n");
            Console.WriteLine("1.1 REGISTRO EQUIPO");
            Console.WriteLine("1.2 REGISTRO JUGADOR");
            Console.WriteLine("1.3 REGISTRO ENTRENADOR");
            Console.WriteLine("1.4 REGISTRO MASAJISTA");
            Console.WriteLine("1.5 VENTA DE JUGADOR");
            Console.WriteLine("1.6 REGRESAR AL MENU PRINCIPAL");
            return Convert.ToDouble(Console.ReadLine());
        }
    }  