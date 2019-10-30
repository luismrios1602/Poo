/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 07:13 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace DemoList2
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool continuar=true;
			int cantEstudiantes=0;
			String seleccion;
			Console.WriteLine("Lista de estudiantes:\n ");
			List<Estudiantes> estudiList=new List<Estudiantes>();
			
			while (continuar) {
				cantEstudiantes++;
				Estudiantes estudiante=new Estudiantes();
				Console.WriteLine("Ingrese los datos del "+cantEstudiantes+"° estudiante: ");
				Console.Write("Documento: ");
				estudiante.documento = Console.ReadLine();
				Console.Write("Nombres: ");
				estudiante.nombres = Console.ReadLine();
				estudiList.Add(estudiante);
				
				Console.WriteLine("¿Continuar?");
				seleccion = Console.ReadLine();
				
				if (seleccion.Equals("false")) {
					continuar = false;
				}
			}
			
			Console.Clear();
			
			foreach (var item in estudiList) {
				Console.WriteLine("Documento: "+item.documento);
				Console.WriteLine("Nombre: "+item.nombres);
				Console.WriteLine("_____________________________");
			}
			
			Console.WriteLine("\nLa cantidad de Estudiantes es: "+estudiList.Count);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}