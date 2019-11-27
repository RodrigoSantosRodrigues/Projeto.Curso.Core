using Projeto.Curso.Core.Domain.Shared.Entidades;

namespace Projeto.Curso.Domain.Pedidos.Entidades
{
    public class Produtos : EntidadeBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }
        public int IdFornecedor { get; set; }

        public override bool EstaConsistente()
        {
            throw new System.NotImplementedException();
        }
    }
}
