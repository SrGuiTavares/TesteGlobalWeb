using TesteTecnico.Application.ViewModel;
using TesteTecnico.Domain.Entites;

namespace TesteTecnico.Application.Interface
{
    public interface IUsuarioAppService : IBaseAppService<UsuarioViewModel>
    {
        Task<UsuarioViewModel> SelecionarPorDocumento(string documento);
    }
}
