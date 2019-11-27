namespace Projeto.Curso.Core.Pedidos.Entidades
{
    public class ItemsPedidos
    {
        public int Id { get; set; }
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
    }
}
