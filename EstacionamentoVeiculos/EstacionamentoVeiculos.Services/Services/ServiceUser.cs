using AutoMapper;
using EstacionamentoVeiculos.Domain.Model;
using EstacionamentoVeiculos.Infra;
using EstacionamentoVeiculos.Infra.Interfaces;
using EstacionamentoVeiculos.Services.Interfaces;
using System;

namespace EstacionamentoVeiculos.Services.Services
{
    public class ServiceUser : IServiceUser
    {
        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor

        public ServiceUser(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        #endregion


        public Usuario GetUserById(Guid id)
        {
            var user = _unitOfWork.Users.Query(x => x.Id == id);

            if (user == null)
            {
                throw new Exception("Usuario invalido");
            }

            return user;
        }

    }
}
