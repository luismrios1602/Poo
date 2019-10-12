/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 7:55 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Dependencia
{
	/// <summary>
	/// Description of Documento.
	/// </summary>
	public class Documento
	{
		private String texto;
 
    	public Documento(String texto) {
    	    this.texto = texto;
    	}
 
    	public String getTexto() {
        return this.texto;
    	}
	}
}
