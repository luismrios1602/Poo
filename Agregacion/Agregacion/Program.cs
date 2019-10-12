/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 6:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Agregacion
{
	class Program
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Licuadora objLicuadora = new Licuadora();
			objLicuadora.Licuar();
			objLicuadora.Apagar();

			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}