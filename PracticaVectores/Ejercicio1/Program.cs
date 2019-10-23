/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 22/10/2019
 * Hora: 8:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			String [] nombres = new string[5];
			int [] salarios = new int[5];
			int mayor=0; //Que me guarde el salario mayor
			int ubicacion=0; //Que me almacene la ubicación del mayor
			
			//Pedir Datos
			for (int i = 0; i < nombres.Length; i++) {
				Console.WriteLine("Ingrese los datos del "+(i+1)+"° trabajador: ");
				Console.Write("Nombre: ");
				nombres[i] = Console.ReadLine();
				Console.Write("Salario: $");
				salarios[i] = int.Parse(Console.ReadLine());
			}
			
			//Mostrar datos
			for (int i = 0; i < salarios.Length; i++) {
				if (salarios[i]>mayor) {
					
					mayor=salarios[i];
					ubicacion=i;
				}
			}
			
			Console.WriteLine("El empleado con mayor salario es: ");
			Console.WriteLine("Nombre: "+nombres[ubicacion]);
			Console.WriteLine("Salario: $"+salarios[ubicacion]);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}