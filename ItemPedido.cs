using exemploEntidadesRelacionais.Models;
using Microsoft.Identity.Client;

namespace exemploEntidadesRelacionais
{
	public class ItemPedido
	{
		public int PedidoId { get; set; }
		public int ProdutoId { get; set; }
		public int Quantidade { get; set; }

		public Produto Produto { get; set; }
		public Pedido Pedido { get; set; }
 	}
}
