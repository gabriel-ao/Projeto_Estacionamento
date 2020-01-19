using AutoMapper;
using EstacionamentoVeiculos.Infra.Entities;

namespace EstacionamentoVeiculos.Infra
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Model.Usuario, Usuario>().ReverseMap();
        }
    }
}
