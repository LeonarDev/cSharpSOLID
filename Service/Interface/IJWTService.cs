using solidInCsharp.Model;

namespace solidInCsharp.Service.Interface
{
    public interface IJWTService
    {
        public string GerarToken(Usuario usuario);
    }
}
