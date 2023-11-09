using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Repository;
using TesteTecnico.Infra.Core.Context;

namespace TesteTecnico.Infra.Core.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context)
        {
        }
    }
}
