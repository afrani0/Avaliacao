﻿// <auto-generated />
using AvaliacaoTecnica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AvaliacaoTecnica.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20210609193900_CriandoTabelas2")]
    partial class CriandoTabelas2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvaliacaoTecnica.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new { Id = 1, Nome = "Tie" },
                        new { Id = 2, Nome = "Vendas" }
                    );
                });

            modelBuilder.Entity("AvaliacaoTecnica.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Nome");

                    b.Property<double>("Salario");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("pessoas");

                    b.HasData(
                        new { Id = 1, DepartamentoId = 1, Nome = "Joe", Salario = 70000.0 },
                        new { Id = 2, DepartamentoId = 2, Nome = "Henry", Salario = 80000.0 },
                        new { Id = 3, DepartamentoId = 2, Nome = "Sam", Salario = 60000.0 },
                        new { Id = 4, DepartamentoId = 1, Nome = "Max", Salario = 90000.0 }
                    );
                });

            modelBuilder.Entity("AvaliacaoTecnica.Models.Pessoa", b =>
                {
                    b.HasOne("AvaliacaoTecnica.Models.Departamento", "Departamento")
                        .WithMany("Pessoas")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
