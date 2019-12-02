﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Projeto.Curso.Core.Domain.Pedidos.Entidades;
using Projeto.Curso.Domain.Pedidos.Entidades;
using System.IO;

namespace Projeto.Curso.Core.Infra.Data.Context
{
    public class ContextEFPedidos : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Pedidoss> Pedidos { get; set; }
        public DbSet<ItensPedidos> ItensPedidos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Clientes> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidosMapping());
            modelBuilder.ApplyConfiguration(new ItensPedidosMapping());
            modelBuilder.ApplyConfiguration(new ProdutosMapping());
            modelBuilder.ApplyConfiguration(new ClientesMapping());
            modelBuilder.ApplyConfiguration(new FornecedoresMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
