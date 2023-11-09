using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Repository;
using TesteTecnico.Domain.Interface.Service;

namespace TesteTecnico.Domain.Service
{
    public class UsuarioService : BaseService<Usuario, IUsuarioRepository>, IUsuarioService
    {
        public UsuarioService(IUsuarioRepository repository) : base(repository)
        {
        }
    }
}
