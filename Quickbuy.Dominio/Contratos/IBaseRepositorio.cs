using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity>: IDisposable where TEntity :class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int Id);
        IEnumerable<TEntity> ObterDados();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
