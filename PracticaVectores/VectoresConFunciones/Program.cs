/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 22/10/2019
 * Hora: 9:06 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace VectoresConFunciones
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int cant;
			Console.Write("Ingrese la cantidad de empleados: ");
			cant = int.Parse(Console.ReadLine());
			String [] nombres=new String[cant];
			
			Console.Clear();
			for (int i = 0; i < cant; i++) {
				nombres[i]=CargarVector(cant, i);
			}
			
			for (int i = 0; i < nombres.Length; i++) {
				Console.WriteLine(nombres[i]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static String CargarVector(int cant, int i){
				String [] nombres=new String[cant];
				float [] salarios=new float[cant];
				
				Console.WriteLine("Ingrese la información del "+(i+1)+"° empleado: ");
				Console.Write("Nombre: ");
				nombres[i] = Console.ReadLine();
				Console.Write("Salario: ");
				salarios[i] = float.Parse(Console.ReadLine());
				return nombres[i];
			}
		
	}
}