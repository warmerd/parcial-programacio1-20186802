using System;
using System.Collections.Generic;
using System.Text;

namespace cajero_1er_parcial
{
	class retiro
	{
		public void retirar()
		{
			menu menu_principal = new menu(); 
			proceso_dispensiones dispensiones = new proceso_dispensiones();
			try
			{
				Console.Clear();
				Console.WriteLine("Digite la cantidad que desea retirar");
				int cantidad = Convert.ToInt32(Console.ReadLine());
				if (cantidad >= 100 && cantidad % 100 == 0) 
				{

					if (Program.opciones_dispencion == 1)
					{
						if (cantidad % 1000 == 100 || cantidad % 1000 == 300 || cantidad % 1000 == 500 || cantidad % 1000 == 700 || cantidad % 1000 == 9000 || cantidad == 100 || cantidad == 300 || cantidad == 500 || cantidad == 700 || cantidad == 900)
						{
							Console.WriteLine("Este cajero solo retira billetes de 200 y 1000 \nDesea realizar otra transaccion? S/N");
							string opcion = Console.ReadLine().ToUpper();
							switch (opcion)
							{
								case "S":
									retirar();
									break;
								case "N":
									Console.WriteLine("VOLVIENDO AL MENU . . .");
									Console.ReadKey();
									menu_principal.menu_principal();
									break;
								default:
									Console.WriteLine("VOLVIENDO AL MENU . . .");
									Console.ReadKey();
									menu_principal.menu_principal();
									break;
							}
							Console.ReadKey();
							menu_principal.menu_principal();
						}
						else
						{
							Console.WriteLine(dispensiones.modo_200_1000(cantidad));
							Console.ReadKey();
							menu_principal.menu_principal();
						}

					}
					else if (Program.opciones_dispencion == 2)
					{
						Console.WriteLine(dispensiones.modo_100_500(cantidad));
						Console.ReadKey();
						menu_principal.menu_principal();
					}
					else if (Program.opciones_dispencion == 3)
					{
						Console.WriteLine(dispensiones.modo_eficiente(cantidad));
						Console.ReadKey();
						menu_principal.menu_principal();
					}

				}
				else
				{
					Console.WriteLine("Este cajero solo dispensa billetes de *100*, *200*, *500* y *1000* \nDesea realizar otro retiro? S/N");
					string opcion = Console.ReadLine().ToUpper();
					switch (opcion)
					{
						case "S":
							retirar();
							break;
						case "N":
							Console.WriteLine("VOLVIENDO AL MENU . . .");
							Console.ReadKey();
							menu_principal.menu_principal();
							break;
						default:
							Console.WriteLine("VOLVIENDO AL MENU . . .");
							Console.ReadKey();
							menu_principal.menu_principal();
							break;
					}
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Este cajero solo dispensa billetes enteros.");
				Console.ReadKey();
				menu_principal.menu_principal();
				throw;
			}
		}
	}
}