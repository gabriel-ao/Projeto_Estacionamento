using AutoMapper;
using EstacionamentoVeiculos.Domain.Model;
using EstacionamentoVeiculos.Infra;
using EstacionamentoVeiculos.Infra.Interfaces;
using EstacionamentoVeiculos.Services.Interfaces;
using EstacionamentoVeiculos.Infra.Libraries.Lang;
using System;
using System.Collections.Generic;

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

        public List<Usuario> GetAllUserById()
        {
            List<Usuario> user = new List<Usuario>();

            user = _unitOfWork.Users.List();

            if (user == null)
            {
                throw new Exception("Usuario invalido");
            }

            return user;
        }

        public string CadastrarUsuario(Usuario user)
        {
            _unitOfWork.Users.Add(user);
            _unitOfWork.Commit();
            return Mensagem.MSG_S001;
        }

        public Usuario EditarUsuario(Usuario user)
        {
            var retorno = GetUserById(user.Id);

            if (retorno != null)
            {
                _unitOfWork.Users.Update(user);
                _unitOfWork.Commit();
            }

            return retorno;
        }

        public string DesativarUsuarioService(Guid id)
        {
            var retorno = GetUserById(id);

            if (retorno.Active != false)
            {
                retorno.Active = false;

                _unitOfWork.Users.Update(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_D001;
            }
            return Mensagem.MSG_D003;
        }

        public string AtivarUsuarioService(Guid id)
        {
            var retorno = GetUserById(id);

            if (retorno.Active != true)
            {
                retorno.Active = true;

                _unitOfWork.Users.Update(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_S002;
            }
            return Mensagem.MSG_S003;
        }

        public string DeletarUsuarioService(Guid id)
        {
            var retorno = GetUserById(id);

            if (retorno.Id != null)
            {
                _unitOfWork.Users.Delete(retorno);
                _unitOfWork.Commit();
                return Mensagem.MSG_D001;
            }
            return Mensagem.MSG_D002;
        }
    }
}
