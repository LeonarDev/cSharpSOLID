using solidInCsharp.Model;

namespace solidInCsharp.Interface
{
    public interface IUsuarioRepository : IReadWriteRepository<Usuario>
    {
        public Usuario ObterUsuario(string Email);
    }
}
