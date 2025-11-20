namespace SmartStock
{
    public class ControlaEstoque
    {
        public int Id { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string TipoMovimento { get; set; } // Requisição ou Devolução
        public DateTime DataMovimento { get; set; }

        // Foreign key para Produto
        public int IdProduto { get; set; }
    }
}
