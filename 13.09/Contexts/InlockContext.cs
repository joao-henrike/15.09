using _13._09.Domains;
using Microsoft.EntityFrameworkCore;

namespace _13._09.Contexts
{
    public class InlockContext : DbContext
    {
        ///defini;'ao das entidades do banco de dados
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Estudio> Estudio { get; set; }

        public DbSet<Estudio> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE02-S15;Database=inlock _WebApi.CodeFirst.Joao;User Id = sa;Pwd = Senai@134;TrustServerCertificate = True");
            optionsBuilder.UseSqlServer();   
        }
    }
}
