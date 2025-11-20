namespace SmartStock
{
    public class Pedido
    {
        public int Id { get; set; }
        public string ClienteNome { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string TipoEntrega { get; set; } //Entrega ou Retirada
        public string EnderecoEntrega { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
        //public List<ItemPedido> ItensPedido { get; set; }
    }
}
