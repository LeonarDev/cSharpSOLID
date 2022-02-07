using System;
using solidInCsharp.Model;
using solidInCsharp.Repository.Interface;
using solidInCsharp.Service.Interface;

namespace solidInCsharp.Service
{
    public class UsuarioService : IUsuarioService
    {
		private IUsuarioRepository Repository;
		private ICriptografiaService CriptografiaService;
		private IJWTService JWTService;

        public UsuarioService(IUsuarioRepository repository, ICriptografiaService criptografiaService, IJWTService jwtService)
		{
			Repository = repository;
			CriptografiaService = criptografiaService;
			JWTService = jwtService;
		}

		public void CriarUsuario(string Email, string Nome, string Senha) {
			var usuario = Repository.ObterUsuario(Email);
			if (usuario != null) throw new Exception("Erro, usuário já existe");
			usuario = new Usuario() { Email = Email, Nome = Nome, Senha = CriptografiaService.CriptografarSenha(Senha)};
			this.Repository.Add(usuario);
		}

		public string Login(string Email,  string Senha) {
			var usuario = Repository.ObterUsuario(Email);
			if (usuario == null || !CriptografiaService.ValidarSenha(usuario.Senha, Senha))
				throw new Exception("Erro, usuário ou senha incorreto");
			return JWTService.GerarToken(usuario);
		}
    }
}
