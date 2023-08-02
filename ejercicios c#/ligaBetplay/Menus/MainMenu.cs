namespace ligaBetplay.Menus;
    
    public class MainMenu
    {
        public int menu()
        {
            Console.WriteLine("\n---------------------------------- Liga Betplay ----------------------------------\n");
            Console.WriteLine("1. REGISTRO PLANTEL");
            Console.WriteLine("2. CONSULTA DE DATOS");
            Console.WriteLine("3. SALIR");
            return Convert.ToInt32(Console.ReadLine);
        }
    }  