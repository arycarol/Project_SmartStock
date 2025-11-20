using Microsoft.EntityFrameworkCore;
using SmartStock.Controllers;

namespace SmartStock.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options) 
        {
        }

        public DbSet<Produto> ProdutoTable { get; set; }
        public DbSet<Pedido> PedidoTable { get; set; }
        public DbSet<ControlaEstoque> ControlaEstoque { get; set; }
    }
}
