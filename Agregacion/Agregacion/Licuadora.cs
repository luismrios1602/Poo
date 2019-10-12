/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 6:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Agregacion
{
	/// <summary>
	/// Description of Licuadora.
	/// </summary>
	public class Licuadora
	{
		String Marca;
	// Instanciamos un objeto de la clase Motor 
		Motor objMotor = new Motor();
	// Al hacer esto, estamos agregando el motor a la licuadora 
		public void Licuar(){
			objMotor.Funcionando();
			Console.WriteLine("Licuando...");
		}	
		public void Apagar(){
			objMotor.Apagado();
			Console.WriteLine("Apagado");
		}
		public Licuadora()
		{
		}
	}
}
