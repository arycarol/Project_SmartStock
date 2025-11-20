using SmartStock.Controllers;

namespace SmartStock
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal TotalItem { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        //Foreign key para Pedido
        public int PedidoId { get; set; }
        //Foreign key para Produto
        public int ProdutoId { get; set; }
    }
}
