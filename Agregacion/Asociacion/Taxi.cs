/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/10/2019
 * Hora: 7:43 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Asociacion
{
	/// <summary>
	/// Description of Taxi.
	/// </summary>
	public class Taxi
	{
	Chofer chofer;
    String matricula;
 
    public Taxi(Chofer chofer, String matricula) {
        this.chofer = chofer;
        this.matricula = matricula;
    }
 
    public void printMatricula() {
        Console.WriteLine(this.matricula);
    }
 
    public void printChofer() {
        String nombreChofer = this.chofer.getNombre();
        Console.WriteLine(nombreChofer);
    }

}
}