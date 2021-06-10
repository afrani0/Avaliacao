using AvaliacaoTecnica.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoTecnica
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<Pessoa> Pessoas  { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //populando as tabelas

            modelBuilder.Entity<Departamento>()
                .HasData(new Departamento { Id = 1, Nome = "Ti" },
                new Departamento { Id = 2, Nome = "Vendas"});

            modelBuilder.Entity<Pessoa>()
                .HasData(new Pessoa { Id = 1, Nome = "Joe", Salario = 70000, DepartamentoId = 1 },
                new Pessoa { Id = 2, Nome = "Henry", Salario = 80000, DepartamentoId = 2 },
                new Pessoa { Id = 3, Nome = "Sam", Salario = 60000, DepartamentoId = 2 },
                new Pessoa { Id = 4, Nome = "Max", Salario = 90000, DepartamentoId = 1 });
        }
    }
}