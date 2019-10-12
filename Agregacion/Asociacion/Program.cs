/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 7:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Asociacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Chofer miChofer = new Chofer("Pedro");
			Taxi miTaxi = new Taxi(miChofer, "AHJ-1050");
			miTaxi.printChofer();
			miTaxi.printMatricula();

			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}