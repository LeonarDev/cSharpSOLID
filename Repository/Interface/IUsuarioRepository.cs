using solidInCsharp.Model;

namespace solidInCsharp.Repository.Interface
{
    public interface IUsuarioRepository : IReadWriteRepository<Usuario>
    {
        public Usuario ObterUsuario(string Email);
    }
}
