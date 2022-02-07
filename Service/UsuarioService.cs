using System;
using solidInCsharp.Model;
using solidInCsharp.Repository;

namespace solidInCsharp.Service
{
    public class UsuarioService
    {
		private UsuarioRepository repository;

        public UsuarioService(UsuarioRepository repository){ 
			this.repository = repository;
		}

		public void CriarUsuario(string Email, string Nome, string Senha) {
			var usuario = repository.ObterUsuario(Email);
			if (usuario != null) throw new Exception("Erro, usuário já existe");
			usuario = new Usuario() { Email = Email, Nome = Nome, Senha = new CriptografiaService().CriptografarSenha(Senha)};
			this.repository.Add(usuario);
		}

		public string Login(string Email,  string Senha) {
			var usuario = repository.ObterUsuario(Email);
			if (usuario == null || !new CriptografiaService().ValidarSenha(usuario.Senha, Senha))
				throw new Exception("Erro, usuário ou senha incorreto");
			return new JWTService().GerarToken(usuario);
		}
    }
}
