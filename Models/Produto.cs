namespace exemploEntidadesRelacionais.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; } = string.Empty;
		public decimal Preco { get; set; }
		public List<Tag> Tags { get; set; } = new List<Tag>();

		public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();


	}
}
