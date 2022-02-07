namespace solidInCsharp.Service.Interface
{
    public interface IUsuarioService
    {
        public void CriarUsuario(string Email, string Nome, string Senha);
		public string Login(string Email,  string Senha);
    }
}
