using AutoMapper;
using TesteTecnico.Application.Interface;
using TesteTecnico.Application.ViewModel;
using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Service;

namespace TesteTecnico.Application.Service
{
    public class UsuarioAppService : BaseService<Usuario, UsuarioViewModel, IUsuarioService>, IUsuarioAppService
    {
        public UsuarioAppService(IUsuarioService _domainService, IMapper mapper) : base(_domainService, mapper)
        {
        }

        public async Task<UsuarioViewModel> SelecionarPorDocumento(string documento)
        {
            return _mapper.Map<UsuarioViewModel>(_domainService.SelecionarPorDocumento(documento));
        }
    }
}
