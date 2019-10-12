/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 7:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Dependencia
{
	/// <summary>
	/// Description of Impresora.
	/// </summary>
	
	//Clase Impresora
	public class Impresora
	{
		public Impresora() {
 
    	}
 
    	public void imprimir(Documento documento) {
        	String texto = documento.getTexto();
        	Console.WriteLine(texto);
    	}
	}
}
