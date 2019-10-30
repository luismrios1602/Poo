/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 06:45 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace DemoList
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum=0;
			
			Console.WriteLine("Ejercicio List");
			List<int> lista=new List<int>();
			
			
			lista.Add(5);
			lista.Add(2);
			lista.Add(6);
			lista.Add(9);
			Console.Write("|");
			foreach (var item in lista) {
				Console.Write(" "+item+" |");
				sum += item;
			}
			
			Console.WriteLine("\nEl valor de la suma es: "+sum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}