using ColunasCalculadasEF.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>()
            .Property(p => p.ValorTotalEstoque)
            .HasComputedColumnSql("[PrecoUnitario] * [QuantidadeEmEstoque]", stored: false);
    }
}
