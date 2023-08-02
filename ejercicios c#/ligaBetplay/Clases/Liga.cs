namespace ligaBetplay.Clases
{
    public class Liga
    {
        int id {get; set;}
        string  nombre {get; set;}

        List<Equipo> equipos {get; set;}

        public Liga(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.equipos = new List<Equipo>();
        }
    }
}