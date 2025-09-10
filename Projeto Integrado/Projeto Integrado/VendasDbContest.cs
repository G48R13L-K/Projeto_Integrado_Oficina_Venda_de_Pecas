using Microsoft.EntityFrameworkCore;

namespace Projeto_Integrado
{
    public class VendasDbContest:DbContext
    {
        public VendasDbContest() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "Server=localhost;Database=Vendas;User=root;Password=";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendaSelecionada>(entity =>
            {
                entity.Property(e => e.PrecoTotal).HasColumnType("decimal(10,2)");

            });
            modelBuilder.Entity<Peca>(entity =>
            {
                entity.Property(e => e.PrecoPeca).HasColumnType("decimal(8,2)");
            });
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Peca> Pecas { get; set; }

        public DbSet<VendaSelecionada> Vendas { get; set; }
      
        
    }
    
    
}
