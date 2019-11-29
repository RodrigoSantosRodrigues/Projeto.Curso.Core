using Projeto.Curso.Core.Domain.Shared.Entidades;
using System.Linq;

namespace Projeto.Curso.Domain.Pedidos.Entidades
{
    public class ItemsPedidos : EntidadeBase
    {
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }

        public override bool EstaConsistente()
        {
            QuantidadeDeveSerSuperiorAZero();
            ItemDePedidoDeveSerAssociadoAUmPedido();
            ProdudoDeveSerPreenchido();
            return !ListaErros.Any();
        }

        private void QuantidadeDeveSerSuperiorAZero()
        {
            if (Qtd <= 0) ListaErros.Add("Quantidade deverá ser informada!");
        }

        private void ItemDePedidoDeveSerAssociadoAUmPedido()
        {
            if (IdPedido <= 0) ListaErros.Add("Numero do pedido inválido!");
        }

        private void ProdudoDeveSerPreenchido()
        {
            if (IdProduto <= 0) ListaErros.Add("Produto deve ser informado!");
        }
    }
}
