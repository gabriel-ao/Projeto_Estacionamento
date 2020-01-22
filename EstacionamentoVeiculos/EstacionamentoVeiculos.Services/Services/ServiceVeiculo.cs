using System;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoVeiculos.Domain.Model;
using EstacionamentoVeiculos.Infra;
using EstacionamentoVeiculos.Infra.Interfaces;
using EstacionamentoVeiculos.Infra.Libraries.Lang;
using EstacionamentoVeiculos.Services.Interfaces;

namespace EstacionamentoVeiculos.Services.Services
{
    class ServiceVeiculo : IServiceVeiculo
    {
        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor
        public ServiceVeiculo(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }
        #endregion

        #region Metodos
        public string AtivarVeiculoService(Guid id)
        {
            var retorno = GetVeiculoById(id);

            if (retorno.Active != true)
            {
                retorno.Active = true;

                _unitOfWork.Veiculos.Update(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_D001;
            }
            return Mensagem.MSG_D003;
        }

        public string CadastrarVeiculoService(Veiculo veiculo)
        {
            _unitOfWork.Veiculos.Add(veiculo);
            _unitOfWork.Commit();
            return Mensagem.MSG_S001;
        }

        public string DeletarVeiculoService(Guid id)
        {
            var retorno = GetVeiculoById(id);

            if (retorno.Id != null)
            {
                _unitOfWork.Veiculos.Delete(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_D001;
            }
            return Mensagem.MSG_D002;
        }

        public string DesativarVeiculoService(Guid id)
        {
            var retorno = GetVeiculoById(id);

            if (retorno.Active != false)
            {
                retorno.Active = false;

                _unitOfWork.Veiculos.Update(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_D001;
            }
            return Mensagem.MSG_D003;
        }

        public string EditarVeiculoService(Veiculo veiculo)
        {
            var retorno = GetVeiculoById(veiculo.Id);

            if(retorno != null)
            {
                _unitOfWork.Veiculos.Update(veiculo);
                _unitOfWork.Commit();
            }
            return retorno.ToString();
        }

        public List<Veiculo> GetAllVeiculoById()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos = _unitOfWork.Veiculos.List();

            if (veiculos == null)
            {
                throw new Exception("Usuario invalido");
            }

            return veiculos;
        }

        public Veiculo GetVeiculoById(Guid id)
        {
            var veiculo = _unitOfWork.Veiculos.Query(x => x.Id == id);

            if (veiculo == null)
            {
                throw new Exception("Usuario invalido");
            }

            return veiculo;
        }

        #endregion


    }
}
