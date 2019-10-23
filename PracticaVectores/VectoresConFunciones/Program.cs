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
			float [] salarios=new float[cant];
			
			Console.Clear();
			CargarVector(cant,nombres, salarios);
			Console.Clear();
			Console.WriteLine("Datos del empleado que más gana: ");
			Console.WriteLine("Nombre: "+nombres[salMayor(salarios)]);
			Console.WriteLine("Salario: "+salarios[salMayor(salarios)]);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void CargarVector(int cant, String[] nombres, float[] salarios){
				
				
				for (int i = 0; i < nombres.Length; i++) {
					
					Console.WriteLine("Ingrese la información del "+(i+1)+"° empleado: ");
					Console.Write("Nombre: ");
					nombres[i] = Console.ReadLine();
					Console.Write("Salario: ");
					salarios[i] = float.Parse(Console.ReadLine());
				
				}
			}
		
		public static int salMayor(float[] salarios){
			float mayor=0;
			int ubicacion=0;
			for (int i = 0; i < salarios.Length; i++) {
				if (salarios[i]>mayor) {
					mayor=salarios[i];
					ubicacion=i;
				}
			}
			
			return ubicacion;
		}
		
	}
}