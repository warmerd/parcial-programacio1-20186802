using System;
using System.Collections.Generic;
using System.Text;

namespace cajero_1er_parcial
{
    class menu
    {
        public enum opcione_menu
        {
            modo_dispension = 1,
            retiro
        }
        private modo_dispension dispension;
        private retiro retiros;
        public menu()
        {
            dispension = new modo_dispension();
            retiros = new retiro();
        }
        public void menu_principal()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al cajero ITLA.");
                Console.WriteLine(" \n1-Seleccionar modo de dispension \n2-Realizar retiro");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case (int)opcione_menu.modo_dispension:
                        dispension.menu_dispension();
                        break;
                    case (int)opcione_menu.retiro:
                        if (Program.opciones_dispencion != 0)
                        {
                            retiros.retirar();
                        }
                        else
                        {
                            Console.WriteLine("Antes de continuar debe seleccionar un modo de dispension");
                            Console.ReadKey();
                            menu_principal();
                        }

                        break;
                    default:
                        Console.WriteLine("Error, dijite una opcion validad .");
                        Console.ReadKey();
                        menu_principal();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error,dijite una opcion valida.");
                Console.ReadKey();
                menu_principal();
                throw;
            }

        }
    }
}
