﻿using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EstacionamentoVeiculos.Domain.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> List(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        List<T> Find(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        T Query(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Guid Incluir(T entity);
        T Buscar(T entity);
        T Alterar(T entity);
        bool Deletar(T entity);
        

    
    }
}
