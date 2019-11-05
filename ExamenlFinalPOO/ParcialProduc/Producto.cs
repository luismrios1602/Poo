/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 05/11/2019
 * Hora: 06:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ParcialProduc
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		public int codigo;
		public double costo, precioVenta;
		public string nombreProducto;
		
		public double getUtilidad (){
			double Utilidad;
			
			Utilidad = this.precioVenta - this.costo;
			return Utilidad;
		}
		
		public Producto()
		{
		}
	}
}
