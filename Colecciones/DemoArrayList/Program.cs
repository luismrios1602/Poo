/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 29/10/2019
 * Hora: 6:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace DemoArrayList
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList AL = new ArrayList();
			
			AL.Add("Mi primer ArrayList");
			AL.Add(5);
			Carro car=new Carro();
			car.placa = "HFF-626";
			car.marca = "Mazda";
			AL.Add(car);
			Carro carrito=(Carro)AL[2];
			
			Console.WriteLine("En la posición 0: "+AL[0]);
			Console.WriteLine("En la posición 1: "+AL[1]);
			Console.WriteLine("En la posición 2: "+carrito.marca);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}