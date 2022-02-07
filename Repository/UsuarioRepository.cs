using Microsoft.EntityFrameworkCore;
using solidInCsharp.Model;
using System.Linq;

namespace solidInCsharp.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario, UsuarioRepository>
    {
        public UsuarioRepository(DbContextOptions<UsuarioRepository> options)
			: base(options)
		{ }

        public Usuario ObterUsuario(string Email)
        {
			var usuario = (from u in this.Items where u.Email == Email select u).FirstOrDefault();
            return usuario;
        }
    }
}
