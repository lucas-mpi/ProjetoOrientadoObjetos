using AtendimentoAoCliente.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AtendimentoAoCliente.Contextos
{
    internal class AtendimentoDbContext : DbContext
    {
        public DbSet<Atendimentos> Atendimentos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Setores> Setores { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite(connectionString: "DataSource=app.db");




    }
}
