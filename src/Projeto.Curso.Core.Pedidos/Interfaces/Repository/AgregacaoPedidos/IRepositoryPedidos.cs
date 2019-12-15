using Projeto.Curso.Core.Domain.Pedidos.AgregacaoPedidos;
using Projeto.Curso.Domain.Pedidos.AgregacaoPedidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Domain.Pedidos.Interfaces.Repository.AgregacaoPedidos
{
    public interface IRepositoryPedidos : IRepository<Pedidoss>
    {
        void AdicionarItensPedidos(ItensPedidos item);
        void AtualizarItensPedidos(ItensPedidos item);
        void RemoverItensPedidos(ItensPedidos item);
        ItensPedidos ObterItensPedidosPorId(int id);
        IEnumerable<ItensPedidos> ObterItensPedido(int idpedido);
    }
}
