using TesteTecnico.Domain.Entites;

namespace TesteTecnico.Domain.Interface.Service
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Task<Usuario> SelecionarPorDocumento(string documento);
    }
}
