namespace exemploEntidadesRelacionais.Models
{
	public class Pedido
	{
		public int Id { get; set; }
		public DateTime Data { get; set; }

		public string Status { get; set; } = string.Empty;

		public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
	}
}
