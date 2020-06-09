using System;
using System.Collections.Generic;
using System.Text;

namespace cajero_1er_parcial
{
    public enum dispensiones
    {
        doscientos_mil = 1,
        cien_quinientos
    }
    class modo_dispension
    {
        public void menu_dispension()
        {
            try
            {
                Console.Clear();
                menu menu_principal = new menu();
                Console.WriteLine("Elija una opcion");
                Console.WriteLine(" \n1-Dispensar 200 y 1000 \n2-Dispensar 100 y 500\n3-Modo eficiente.");
                Program.opciones_dispencion = Convert.ToInt32(Console.ReadLine());
                switch (Program.opciones_dispencion)
                {
                    case 1:
                        Console.WriteLine("MODO DE DISPENSION 200 Y 1000 HA SIDO SELECCIONADO");
                        Console.ReadLine();
                        menu_dispension();
                        break;
                    case 2:
                        Console.WriteLine("MODO DE DISPENSION 100 Y 500 HA SIDO SELECCIONADO");
                        Console.ReadLine();
                        menu_dispension();
                        break;
                    case 3:
                        Console.WriteLine("MODO DE DISPENSION EFICIENTE HA SIDO SELECCIONADO");
                        Console.ReadLine();
                        menu_dispension();
                        break;
                    default:
                        Console.WriteLine("Error, dijite una opcion valida .");
                        menu_dispension();
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception)
            {
                menu menu_principal = new menu();
                Console.WriteLine("Error, dijite una opcion valida .");
                menu_dispension();
                Console.ReadKey();
                
            }


        }

    }
}
