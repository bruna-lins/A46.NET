using Agencia46.Models;
using Microsoft.EntityFrameworkCore;

namespace Agencia46.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Destinos> Destinos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FREP7SU; Initial Catalog=CRUDAgencia46; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(table =>
            {
                table.ToTable("Usuarios");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Email).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Endereco).HasMaxLength(50).IsRequired();
            });

            modelBuilder.Entity<Destinos>(table =>
            {
                table.ToTable("Destinos");
                table.HasKey(prop => prop.Id_Destino);

                table.Property(prop => prop.Nome_Dest).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Pais).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Preco).HasColumnType("money").IsRequired();
                table.Property(prop => prop.Status).HasConversion<string>().IsRequired();
            });

            modelBuilder.Entity<Origem>(table =>
            {
                table.ToTable("Origem");
                table.HasKey(prop => prop.Id_Origem);

                table.Property(prop => prop.Nome_Ori).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Pais).HasMaxLength(40).IsRequired();
            });

            modelBuilder.Entity<Viagem>(table =>
            {
                table.ToTable("Viagem");
                table.HasKey(prop => prop.Id_Viagem);

                table.Property(prop => prop.Id_Origem).IsRequired();
                table.Property(prop => prop.Id_Destino).IsRequired();
                table.Property(prop => prop.Id_Pagamento).IsRequired();
                table.Property(prop => prop.Tipo_pag).HasConversion<string>().IsRequired();
                table.Property(prop => prop.Parcelas).IsRequired();
                table.Property(prop => prop.data_pagamento).HasColumnType("date").IsRequired();
            });

            modelBuilder.Entity<Agendamento>(table =>
            {
                table.ToTable("Agendamento");
                table.HasKey(prop => prop.Id_Agendamento);

                table.Property(prop => prop.Id_Viagem).IsRequired();
                table.Property(prop => prop.Id_Cliente).IsRequired();
                table.Property(prop => prop.Num_Voo).IsRequired();
                table.Property(prop => prop.Assento).IsRequired();
            });
        }
    }
}
