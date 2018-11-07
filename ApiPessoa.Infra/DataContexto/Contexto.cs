using ApiPessoa.Domain.Entidades;
using ApiPessoa.Infra.Maps;
using ApiPessoa.Shared;
using Microsoft.EntityFrameworkCore;

namespace ApiPessoa.Infra.DataContexto
{
    public class Contexto : DbContext
    {

        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Setting.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CargoMap());
        }

    }
}
