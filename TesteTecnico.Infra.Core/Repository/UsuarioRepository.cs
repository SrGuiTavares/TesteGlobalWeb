using Microsoft.EntityFrameworkCore;
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

        public async Task<Usuario> SelecionarPorDocumento(string documento)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var usuario = await _context.Usuarios.Where(x => x.Documento == documento).FirstOrDefaultAsync();

                    transaction.Commit();

                    return usuario;
                }
                catch (Exception ex)
                {
                    return new Usuario();
                }
            }
        }
    }
}
