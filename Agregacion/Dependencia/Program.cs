/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 7:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Dependencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Documento miDocumento = new Documento("Probando!");
			Impresora miImpresora = new Impresora();
			miImpresora.imprimir(miDocumento);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}