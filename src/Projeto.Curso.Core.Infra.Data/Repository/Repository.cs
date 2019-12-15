using Microsoft.EntityFrameworkCore;
using Projeto.Curso.Core.Domain.Pedidos.Interfaces.Repository;
using Projeto.Curso.Core.Domain.Shared.Entidades;
using Projeto.Curso.Core.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Projeto.Curso.Core.Infra.Data.Repository
{
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : EntidadeBase
    {
        protected ContextEFPedidos Db;
        protected DbSet<TEntidade> DbSet;

        public Repository(ContextEFPedidos context)
        {
            Db = context;
        }

        public void Adicionar(TEntidade obj)
        {
            DbSet.Add(obj);
        }

        public void Atualizar(TEntidade obj)
        {
            DbSet.Update(obj);
        }

        public void Remover(TEntidade obj)
        {
            DbSet.Remove(obj);
        }

        public IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public TEntidade ObterPorId(int id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TEntidade> ObterTodos()
        {
            return DbSet.ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
