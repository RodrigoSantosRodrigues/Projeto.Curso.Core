﻿using Projeto.Curso.Core.Domain.Pedidos.AgregacaoPedidos;
using Projeto.Curso.Core.Domain.Pedidos.Entidades;
using Projeto.Curso.Core.Domain.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Curso.Domain.Pedidos.AgregacaoPedidos
{
    public class Pedidoss : EntidadeBase
    {
        public DateTime DataPedido { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Observacao { get; set; }
        public int IdCliente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public ICollection<ItensPedidos> ItensPedidos { get; set; }

        public override bool EstaConsistente()
        {
            DataPedidoDeveSerPreenchida();
            DataPedidoDeveSerSuperiorOuIgualADataDoDia();
            DataEntregaDeveSerSuperiorOuIgualDataPedido();
            ClienteDeveSerPreenchido();
            ObservacaoDeveTerUmTamanhoLimite();
            return !ListaErros.Any();
        }

        private void ObservacaoDeveTerUmTamanhoLimite()
        {
            if (!string.IsNullOrEmpty(Observacao) && Observacao.Length > 4000) ListaErros.Add("Campo observação deverá ter no máximo 4000 caracteres");
  
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
