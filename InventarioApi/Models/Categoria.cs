using System;
namespace InventarioApi.Models
{
	public class Categoria
	{
		/// <summary>
		/// Identificador
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Nombre Categoria
		/// </summary>
		public string NombreCategoria { get; set; } = null!;
		/// <summary>
		/// Imagen de la Categoria
		/// </summary>
		public string Imagen { get; set; } = null!;
    }
}

