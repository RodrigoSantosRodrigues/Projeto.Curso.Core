using System;

namespace Projeto.Curso.Core.Pedidos.Entidades
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Status { get; set; }
        public int IdCliente { get; set; }
    }
}
