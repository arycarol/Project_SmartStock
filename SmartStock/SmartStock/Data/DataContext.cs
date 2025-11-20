using Microsoft.EntityFrameworkCore;
using SmartStock.Controllers;

namespace SmartStock.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemPedido>()
                .HasKey(ip => new { ip.PedidoId, ip.ProdutoId });
            modelBuilder.Entity<ItemPedido>()
                .HasOne(ip => ip.Pedido) 
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(ip => ip.PedidoId);
            modelBuilder.Entity<ItemPedido>()
                .HasOne(ip => ip.Produto) 
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(ip => ip.ProdutoId);
        }

        public DbSet<Produto> ProdutoTable { get; set; }
        public DbSet<Pedido> PedidoTable { get; set; }
        public DbSet<ControlaEstoque> ControlaEstoqueTable { get; set; }
        public DbSet<ItemPedido> ItemPedidoTable { get; set; }
    }
}
