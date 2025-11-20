namespace SmartStock
{
    public class ControlaEstoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public DateTime DataMovimento { get; set; }
        public int Quantidade { get; set; }

        // Pode ser "Entrada" ou "Saída"
        public string TipoMovimento { get; set; }

        // Exemplo: "Venda", "Compra", "Ajuste"
        public string Origem { get; set; }
    }
}
