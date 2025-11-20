namespace SmartStock
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string ClienteNome { get; set; }
        public decimal ValorTotal { get; set; }

        // Relacionamento com os itens do pedido
        public ICollection<ItemPedido> Itens { get; set; }
    }
}
