using ligaBetplay.Menus;

class Program
{
    private static void Main(string[] args)
    {
        List<Liga> Ligas = new List<Liga>(); 
        int opcion; 
        MainMenu menuPrincipal = new MainMenu();

        do 
        {
            opcion = menuPrincipal.menu();

            switch (opcion)
            {
                case 1:
                    int opcionPlantel;
                    MenuPlantel menuPlantel = new MenuPlantel();

                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();

                        switch (opcionPlantel)
                         {
                            case 1:
                                Liga ligabuscar= new Liga();
                                Liga opcionliga=ligabuscar.buscarLiga(Ligas);
                                Console.WriteLine(opcionliga.nombre);
                                Equipo equipo = new Equipo();
                                Equipo nuevoequipo = equipo.agregarEquipo();
                                Console.WriteLine(nuevoequipo.nombre);
                                opcionliga.EquiposDeLiga.Add(nuevoequipo);;
                                break;
                            case 2:
                                int opcionBuscar = 0;
                                MenuConsultaDatos menuuConsultaDatos = new MenuConsultaDatos ();
                                do
                                {
                                    opcionPlantel = menuuConsultaDatos.menuConsultaDatos();
                                } while (opcionBuscar != 5);
                                break;
                            case 3:
                                Liga liga = new Liga();
                                Ligas.Add(liga.agregarLiga());
                                liga.mostrarLigas(Ligas);
                                break;
                            case 4:
                                registroMasajista();
                                break;
                            case 5:
                                ventaJuagdor();
                                break;
                            case 6:
                                menuPrincipal.menu();
                                break;                    
                        }
                    } while (opcionEquipo != 6);
                    break;

                case 2:
                    double opcionConsultaDatos;
                    MenuConsultaDatos menuConsultaDatos = new MenuConsultaDatos();

                    do
                    {
                        opcionConsultaDatos = menuConsultaDatos.menuConsultaDatos();

                        switch (opcionConsultaDatos)
                        {
                            case 1.1:
                                listarJugadorXEquipo;
                                break;

                            case 1.2:
                                buscarDelaXEquipos;
                                break;

                            case 1.3:
                                buscarCuerEntreXEquipos;
                                break;

                            case 1.4:
                                menuPrincipal.menu();
                                break;            
                        }
                    } while (opcionConsultaDatos != 1.4);
                    break;

                case 3:
                    break;    
            }
        } while (opcion != 3);
    }
}