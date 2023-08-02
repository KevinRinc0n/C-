namespace ligaBetplay.Menus
{
    public class MenuConsultaDatos
    {
        public double menuConsultaDatos()
        {
            Console.Clear();
            Console.WriteLine("\n---------------------------------- CONSULTA DE DATOS ----------------------------------\n");
            Console.WriteLine("1.1 LISTAR JUGADORES POR EQUIPO");
            Console.WriteLine("1.2 BUCAR LOS DELANTEROS POR EQUIPO");
            Console.WriteLine("1.3 BUCAR CUERPO DE ENTRENADORES POR EQUIPO");
            Console.WriteLine("1.4 REGRESAR AL MENU PRINCIPAL");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}