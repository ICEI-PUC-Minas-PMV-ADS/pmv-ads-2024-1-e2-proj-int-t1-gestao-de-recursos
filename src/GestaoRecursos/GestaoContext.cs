using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Context;

public class GestaoContext : IdentityDbContext
{
    public GestaoContext(DbContextOptions<GestaoContext> options) : base(options)
    {
    }

    public DbSet<TipoProduto> TipoProdutos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<Compra> Compra { get; set; }
    public DbSet<Venda> Venda { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Produto>(entity => entity.HasMany(x => x.Vendas).WithOne(x => x.Produto));
        modelBuilder.Entity<Venda>(modelBuilder => modelBuilder.HasOne(x => x.Produto).WithMany(x => x.Vendas).HasForeignKey(x => x.ProdutoId));
        
        modelBuilder.Entity<Produto>(entity => entity.HasMany(x => x.Compras).WithOne(x => x.Produto));
        modelBuilder.Entity<Compra>(modelBuilder => modelBuilder.HasOne(x => x.Produto).WithMany(x => x.Compras).HasForeignKey(x => x.ProdutoId));

        modelBuilder.Entity<Produto>(entity => entity.HasOne(x => x.TipoProduto).WithMany(x => x.Produtos).HasForeignKey(x => x.TipoProdutoId));
        modelBuilder.Entity<TipoProduto>(entity => entity.HasMany(x => x.Produtos).WithOne(x => x.TipoProduto));
    }


}

