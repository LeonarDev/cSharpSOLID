using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using solidInCsharp.Model;
using solidInCsharp.Service.Interface;

namespace solidInCsharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase {
        private readonly ILogger<UsuarioController> _logger;
		private readonly IUsuarioService usuarioService;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
			this.usuarioService = usuarioService;
        }

        [HttpPost]
		[Route("login")]
		public ActionResult<dynamic> Login([FromBody]Usuario model)
		{
			var token = usuarioService.Login(model.Email, model.Senha);
			return new
			{
				token = token
			};
		}

		[HttpPost]
		public ActionResult<dynamic> CriarUsuario([FromBody]Usuario model)
		{
			usuarioService.CriarUsuario(model.Email, model.Nome, model.Senha);
			return new
			{ };
		}
    }
}
