using Projeto.Curso.Core.Domain.Shared.Entidades;

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
            throw new System.NotImplementedException();
        }
    }
}
