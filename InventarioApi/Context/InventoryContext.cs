using System;
using Microsoft.EntityFrameworkCore;
using InventarioApi.Models;

namespace InventarioApi.Context
{
	public class InventoryContext : DbContext
	{
        public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
        {
        }

        public DbSet<Productos> Productos { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;


    }
}

