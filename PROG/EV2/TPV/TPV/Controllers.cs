using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    public class Controllers
    {
        public static void RunMainMenu(ITPV tpv)
        {
            ViewTPV v = new viewTPV();
            bool IsRunning = true;
            while (IsRunning)
            {
                ViewTPV.MostrarMenuPrincipal(tpv);
                var option = ViewTPV.Leer(tpv);

            }
        }

        public static void RunMainMenu(ITPV tpv)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine("Elige una operación a realizar:");
                Console.WriteLine("1-Buscar Producto");
                Console.WriteLine("2-Buscar Productos");
                Console.WriteLine("3-Añadir Producto");
                Console.WriteLine("4-Eliminar Producto");
                Console.WriteLine("5-Actualizar Producto");
                Console.WriteLine("6-Cerrar Programa");
                var option = Console.ReadLine();
                if (option != null)
                {
                    switch (option)
                    {
                        case "1":
                            {
                                UI.Case1(tpv);
                                break;
                            }
                        case "2":
                            {
                                UI.Case2(tpv);
                                break;
                            }
                        case "3":
                            {
                                UI.Case3(tpv);
                                break;
                            }
                        case "4":
                            {
                                UI.Case4(tpv);
                                break;
                            }
                        case "5":
                            {
                                UI.Case5(tpv);
                                break;
                            }
                        case "6":
                            {
                                UI.Case6(tpv, out IsRunning);
                                break;
                            }
                    }
                }
            }
        }

    }
}
