namespace Projeto.Curso.Core.Pedidos.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }
        public int IdFornecedor { get; set; }
    }
}
