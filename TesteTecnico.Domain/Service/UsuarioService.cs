using TesteTecnico.Domain.Entites;
using TesteTecnico.Domain.Interface.Repository;
using TesteTecnico.Domain.Interface.Service;

namespace TesteTecnico.Domain.Service
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository repository, IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<int> Delete(Usuario entity)
        {
            return await _usuarioRepository.Delete(entity);
        }

        public async Task<int> Insert(Usuario entity)
        {
            var usuario = SelecionarPorDocumento(entity.Documento).Result;

            if (!string.IsNullOrEmpty(usuario.Documento))
                return 0;

            return await _usuarioRepository.Insert(entity);
        }

        public async Task<int> Update(Usuario entity)
        {
            return await _usuarioRepository.Update(entity);
        }

        public async Task<Usuario> SelecionarPorDocumento(string documento)
        {
            return await _usuarioRepository.SelecionarPorDocumento(documento);
        }
    }
}
