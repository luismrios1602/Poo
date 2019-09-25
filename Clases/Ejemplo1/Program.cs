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
			Estudiantes est= new Estudiantes();
			
			Console.Write("Ingresar el documento: ");
			est.documento = int.Parse(Console.ReadLine());
			Console.Write("Ingresar los nombres: ");
			est.nombres = Console.ReadLine();
			Console.Write("Ingresar los apellidos: ");
			est.apellidos = Console.ReadLine();
			Console.Write("Ingresar la carrera: ");
			est.carrera = Console.ReadLine();
			Console.Write("Ingresar el semestre: ");
			est.semestre = int.Parse(Console.ReadLine());
			Console.Write("Ingresar el promedio: ");
			est.promedio = double.Parse(Console.ReadLine());
//			Console.WriteLine("Ingresar la nacionalidad: ");
//			est.nacionalidad = Console.ReadLine();
			
			Console.WriteLine("Hemos creado el objeto");
			Console.WriteLine("El documento es: "+est.documento);
			Console.WriteLine("El nombre es: "+est.nombres);
			Console.WriteLine("El apellido es: "+est.apellidos);
			Console.WriteLine("La carrera es: "+est.carrera);
			Console.WriteLine("El semestre es: "+est.semestre);
			Console.WriteLine("El promedio es: "+est.promedio);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}