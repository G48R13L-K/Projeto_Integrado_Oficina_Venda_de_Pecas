using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Peca> Pecas { get; set; }

        public DbSet<Venda> Vendas { get; set; }



    }
    
    
}
