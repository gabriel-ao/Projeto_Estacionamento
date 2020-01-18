using EstacionamentoVeiculos.Infra.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public interface IRepositoryBase<T> where T : class
{
    List<T> List(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    List<T> Find(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    T Query(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    Guid IncluirCliente(Usuario user);
    Usuario BuscarCliente(Usuario user);
    Usuario AlterarCliente(Usuario user);
    bool DeletarCliente(Usuario user);
        

    
}
