/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 6:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Agregacion
{
	/// <summary>
	/// Description of Motor.
	/// </summary>
	public class Motor
	{
		String Serie;
		int Velocidad;
		public void Funcionando(){
			Console.WriteLine("Motor Girando");
		}	
		public void Apagado(){
			Console.WriteLine("Motor Apagado");
		}
		public Motor()
		{
		}
	}
}
