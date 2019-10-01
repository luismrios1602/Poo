/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 24/09/2019
 * Hora: 6H30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejemplo1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Demo POO");
			
			Persona per= new Persona();
			Console.WriteLine("Ingresar el documentos: ");
			per.documento = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Hemos creado el objeto");
			Console.WriteLine("El documento es: "+per.documento);
			Console.WriteLine("El nombre es: "+per.nombres);
			Console.WriteLine("El apellido es: "+per.apellidos);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}