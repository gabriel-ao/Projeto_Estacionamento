using AutoMapper;
using EstacionamentoVeiculos.Domain.Interfaces;
using EstacionamentoVeiculos.Infra.Context;
using EstacionamentoVeiculos.Infra.Entities;
using EstacionamentoVeiculos.Infra.Repositories.Base;

namespace EstacionamentoVeiculos.Infra.Repositories
{
    public class RepositoryVeiculo : RepositoryBase<Domain.Model.Veiculo, Veiculo>, IRepositoryVeiculo
    {
        #region Atributos

        private IMapper _mapper;

        #endregion

        #region Construtor

        public RepositoryVeiculo(EstacionamentoVeiculosContext context) : base(context)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        #endregion
    }
}
