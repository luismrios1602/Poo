/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 01/10/2019
 * Hora: 6H47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace CDA
{
	class Program
	{
		public static void Main(string[] args)
		{
			int op, condBool;
					
			Console.WriteLine("**********SEDE A :V**********");
			Console.WriteLine("Ingrese el tipo de Vehículo: \n1. Moto \n2.Automovil");
			op = int.Parse(Console.ReadLine());
			
			if (op == 1) {
				Motocicleta moto=new Motocicleta();
				
				Console.WriteLine("::::::::::::::Ingrese los datos del vehículo: ::::::::::::::");
				Console.WriteLine("Placa: ");
				moto.placa = Console.ReadLine();
				Console.WriteLine("Marca: ");
				moto.marca = Console.ReadLine();
				Console.WriteLine("Modelo: ");
				moto.modelo = int.Parse(Console.ReadLine());
				Console.WriteLine("Kilometraje: ");
				moto.kilometraje = int.Parse(Console.ReadLine());
				Console.WriteLine("Color: ");
				moto.color = Console.ReadLine();
				Console.WriteLine("fechaIngreso: ");
				moto.fechaIngreso = Console.ReadLine();
				Console.WriteLine("Cilindraje: ");
				moto.cilindraje = int.Parse(Console.ReadLine());
				Console.WriteLine("Tipo de Freno: ");
				moto.tipoFreno = Console.ReadLine();
				Console.WriteLine("¿Tiene Retrovisor?: \n1. Sí \n0. No");
				condBool = int.Parse(Console.ReadLine());
				if (condBool == 1) {
					moto.tieneRetrovisor = true;
				} else {
					moto.tieneRetrovisor = false;
				}
				
			} else if (op == 2) {
				Automovil carro=new Automovil();
				
				Console.WriteLine("::::::::::::::Ingrese los datos del vehículo: ::::::::::::::");
				Console.WriteLine("Placa: ");
				carro.placa = Console.ReadLine();
				Console.WriteLine("Marca: ");
				carro.marca = Console.ReadLine();
				Console.WriteLine("Modelo: ");
				carro.modelo = int.Parse(Console.ReadLine());
				Console.WriteLine("Kilometraje: ");
				carro.kilometraje = int.Parse(Console.ReadLine());
				Console.WriteLine("Color: ");
				carro.color = Console.ReadLine();
				Console.WriteLine("fechaIngreso: ");
				carro.fechaIngreso = Console.ReadLine();
				Console.WriteLine("Motor: ");
				carro.motor = Console.ReadLine();
				Console.WriteLine("Potencia: ");
				carro.potencia = float.Parse(Console.ReadLine());
				Console.WriteLine("Capacidad: ");
				carro.capacidad = int.Parse(Console.ReadLine());
				Console.WriteLine("¿Está polarizado?: \n1. Sí \n0. No");
				condBool = int.Parse(Console.ReadLine());
				if (condBool == 1) {
					carro.estaPolarizado = true;
				} else {
					carro.estaPolarizado = false;
				}
				Console.WriteLine("¿Tiene baúl?: \n1. Sí \n0. No");
				condBool = int.Parse(Console.ReadLine());
				if (condBool == 1) {
					carro.tieneBaul = true;
				} else {
					carro.tieneBaul = false;
				}
			} else {
				Console.WriteLine("Tipo de vehículo inválido: ");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}