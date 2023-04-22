using System;

namespace InventarioApi.Models
{
	public class Productos
	{
		/// <summary>
		/// Identificador
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Nombre del Producto
		/// </summary>
		public string Producto { get; set; }
		/// <summary>
		/// Precio del Producto
		/// </summary>
		public decimal Precio { get; set; }
		/// <summary>
		/// Cantidad de Productos en Inventario
		/// </summary>
		public int Cantidad { get; set; }
		/// <summary>
		/// Fecha de Ingreso del Producto
		/// </summary>
		public DateTime FechaIngreso { get; set; }

	}
}

