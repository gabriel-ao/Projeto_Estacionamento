using EstacionamentoVeiculos.Infra.Context;
using EstacionamentoVeiculos.Infra.Entities;
using EstacionamentoVeiculos.Infra.Interfaces;
using EstacionamentoVeiculos.Infra.Repositories.Base;
using System;

namespace EstacionamentoVeiculos.Infra.Repositories
{
    public class RepositoryUnitOfWork : RepositoryBase<Domain.Model.UnitOfWork, UnitOfWork>, IRepositoryUnitOfWork
    {
        private readonly EstacionamentoVeiculosContext _context;

        //private RepositoryUser repositoryUser = null;

        private bool disposed = false;

        public RepositoryUnitOfWork(EstacionamentoVeiculosContext context) : base(context)
        {
            _context = context;
        }

        //public IRepositoryUser Users
        //{
        //    get
        //    {
        //        if (repositoryUser == null)
        //        {
        //            repositoryUser = new RepositoryUser(_context);
        //        }
        //        return repositoryUser;
        //    }
        //}

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public new bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
