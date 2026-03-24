using exemploEntidadesRelacionais.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploEntidadesRelacionais.Data
{
	public class AppDbContext : DbContext
	{
		
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Tag> Tags { get; set; }

		public DbSet<Pedido> Pedidos { get; set; }

		public DbSet<ItemPedido> ItensPedido { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<ItemPedido>().
				HasKey(element => new
				{
					element.PedidoId,
					element.ProdutoId
				});

				;
		}


	}
}
