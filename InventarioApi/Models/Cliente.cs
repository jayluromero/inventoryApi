using System;
namespace InventarioApi.Models
{
	/// <summary>
	/// Clase de contactos
	/// </summary>
	public class Cliente
	{
		/// <summary>
		/// Identificador
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Nombre del Cliente
		/// </summary>
		public string Nombre { get; set; } = null!;
        /// <summary>
        /// Apellido del cliente
        /// </summary>
        public string Apellido { get; set; } = null!;
        /// <summary>
        /// Fecha de Nacimiento
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
		/// <summary>
		/// Contacto de Tipo Juridico o Natural
		/// </summary>
		public bool EsJuridico { get; set; }
		/// <summary>
		/// Identificación del Contacto
		/// </summary>
		public string Identificacion { get; set; } = null!;
		/// <summary>
		/// Contacto de Sexo Masculino o Femenino
		/// </summary>
		public bool? EsMasculino { get; set; }
		
	}
}

