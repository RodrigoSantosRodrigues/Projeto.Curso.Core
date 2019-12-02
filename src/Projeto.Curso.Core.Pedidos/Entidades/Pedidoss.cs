﻿using Projeto.Curso.Core.Domain.Pedidos.Entidades;
using Projeto.Curso.Core.Domain.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Curso.Domain.Pedidos.Entidades
{
    public class Pedidoss : EntidadeBase
    {
        public DateTime DataPedido { get; set; }
        public DateTime? DataEntrega { get; set; }
        public int IdCliente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public ICollection<ItensPedidos> ItensPedidos { get; set; }

        public override bool EstaConsistente()
        {
            DataPedidoDeveSerPreenchida();
            DataPedidoDeveSerSuperiorOuIgualADataDoDia();
            DataEntregaDeveSerSuperiorOuIgualDataPedido();
            ClienteDeveSerPreenchido();
            return !ListaErros.Any();
        }

        private void DataPedidoDeveSerPreenchida()
        {
            if (DataPedido == null) ListaErros.Add("Preencha data do pedido!");
        }

        private void DataPedidoDeveSerSuperiorOuIgualADataDoDia()
        {
            if (DataPedido < DateTime.Today) ListaErros.Add("Data do pedido não pode ser superior a data de hoje!");
        }

        private void DataEntregaDeveSerSuperiorOuIgualDataPedido()
        {
            if (DataEntrega != null && DataEntrega < DataPedido) ListaErros.Add("Data da entrega deve ser superior a data do pedido");
        }

        private void ClienteDeveSerPreenchido()
        {
            if (IdCliente == 0) ListaErros.Add("Cliente deve ser informado!");
        }
    }
}
