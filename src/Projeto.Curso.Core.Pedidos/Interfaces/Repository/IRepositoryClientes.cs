using Projeto.Curso.Core.Domain.Pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Domain.Pedidos.Interfaces.Repository
{
    public interface IRepositoryClientes : IRepository<Clientes>
    {
        Clientes ObterPorCpfCnpj(string cpfcnpj);
        Clientes ObterPorApelido(string apelido);
    }
}
