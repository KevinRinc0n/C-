using ligaBetplay.Menus;

class Program
{
    static void Main()
    {
        int opcion; 
        MainMenu menuPrincipal = new MainMenu();

        do 
        {
            opcion = menuPrincipal.menu();

            switch (opcion)
            {
                case 1:
                    double opcionPlantel;
                    MenuPlantel menuPlantel = new MenuPlantel();

                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();

                        switch (opcionPlantel)
                         {
                            case 1.1:
                                registroEquipo();
                                break;
                            case 1.2:
                                registroJugador();
                                break;
                            case 1.3:
                                registroEntrenador();
                                break;
                            case 1.4:
                                registroMasajista();
                                break;
                            case 1.5:
                                ventaJuagdor();
                                break;
                            case 1.6:
                                menuPrincipal.menu();
                                break;                    
                        }
                    } while (opcionEquipo != 1.6);
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