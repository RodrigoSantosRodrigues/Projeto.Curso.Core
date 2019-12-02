using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Curso.Domain.Pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Infra.Data.Mappings
{
    public class PedidosMapping : IEntityTypeConfiguration<Pedidoss>
    {
        public void Configure(EntityTypeBuilder<Pedidoss> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido)
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(p => p.DataEntrega)
                .HasColumnType("DateTime");

            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente);

            builder.Ignore(p => p.ListaErros);

            builder.ToTable("Pedidos");

        }
    }
}
