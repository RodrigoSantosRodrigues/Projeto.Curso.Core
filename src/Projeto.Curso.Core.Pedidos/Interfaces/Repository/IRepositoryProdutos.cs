using Projeto.Curso.Domain.Pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Domain.Pedidos.Interfaces.Repository
{
    public interface IRepositoryProdutos : IRepository<Produtos>
    {
        Produtos ObterPorNome(string nome);
        Produtos ObterPorApelido(string apelido);
    }
}

