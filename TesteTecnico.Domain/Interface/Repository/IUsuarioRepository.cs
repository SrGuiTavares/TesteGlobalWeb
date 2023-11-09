using TesteTecnico.Domain.Entites;

namespace TesteTecnico.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Usuario> SelecionarPorDocumento(string documento);
    }
}
