using AutoMapper;
using TesteTecnico.Application.ViewModel;
using TesteTecnico.Domain.Entites;

namespace TesteTecnico.Application.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BaseEntitie, BaseViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
