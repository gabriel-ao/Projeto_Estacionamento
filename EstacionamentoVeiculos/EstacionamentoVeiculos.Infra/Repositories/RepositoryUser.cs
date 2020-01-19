using AutoMapper;
using EstacionamentoVeiculos.Domain.Interfaces;
using EstacionamentoVeiculos.Infra;
using EstacionamentoVeiculos.Infra.Context;
using EstacionamentoVeiculos.Infra.Entities;
using EstacionamentoVeiculos.Infra.Repositories.Base;
using System;

public class RepositoryUser : RepositoryBase<EstacionamentoVeiculos.Domain.Model.Usuario, Usuario>, IRepositoryUsuario
{

    #region Atributos

    private IMapper _mapper;

    #endregion

    #region Construtor

    public RepositoryUser(EstacionamentoVeiculosContext context) : base(context)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(typeof(MapperProfile));
        });
        _mapper = config.CreateMapper();
    }

    #endregion
}