/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 05/11/2019
 * Hora: 06:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace ParcialProduc
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int op;
			bool continuar=true;
			List<Producto> ListaProduc=new List<Producto>();
			
			do {
				op = Menu();
				if (op==1) {
					Agregar(ListaProduc);
					continuar=true;
				} else if (op==2) {
					Mostrar(ListaProduc);
					continuar=true;
				} else if (op==3) {
					Console.Clear();
					continuar = false;
				} else {
					Console.WriteLine("So ta malo :v");
				}
			
			} while (continuar);

			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Menu(){
			Console.WriteLine("\n::::::::::::::TIENDAS ARA::::::::::::::");
			Console.WriteLine("MENÚ: \n" +
			                  "1. Agregar Productos\n" +
			                  "2. Mostrar Productos\n" +
			                  "3. Salir");
			int op = int.Parse(Console.ReadLine());
			return op;
		}
		
		public static void Agregar(List<Producto> ListaProduc){
			int cant;
				
				Console.Write("Ingrese la cantidad de productos: ");
				cant = int.Parse(Console.ReadLine());
				
				for (int i = 0; i < cant; i++) {
					Producto ObjetProd = new Producto();
					Console.WriteLine("\n************ Ingrese la información del "+(i+1)+"° Producto ************");
					Console.Write("Código: "); ObjetProd.codigo = int.Parse(Console.ReadLine());
					Console.Write("Nombre: "); ObjetProd.nombreProducto = Console.ReadLine();
					Console.Write("Costo: "); ObjetProd.costo = double.Parse(Console.ReadLine());
					Console.Write("Precio de Venta: "); ObjetProd.precioVenta = double.Parse(Console.ReadLine());
					ListaProduc.Add(ObjetProd);
				}
		}
		
		public static void Mostrar(List<Producto> ListaProduc){
			Console.Clear();
			if (ListaProduc.Count>0) {
					
					foreach (Producto Produc in ListaProduc) {
					Console.WriteLine("____________________________________________");
					Console.WriteLine("Codigo: "+Produc.codigo);
					Console.WriteLine("Nombre: "+Produc.nombreProducto);
					Console.WriteLine("Costo: "+Produc.costo);
					Console.WriteLine("Precio de Venta: "+Produc.precioVenta);
					Console.WriteLine("Utilidad: "+Produc.getUtilidad());
					} 
				
				} else {
						Console.WriteLine("No hay Productos!\n");
					}
				
		}
		
	}
}