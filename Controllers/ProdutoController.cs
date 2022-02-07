using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using solidInCsharp.Service.Interface;
using solidInCsharp.Service.Report;
using solidInCsharp.Service;

namespace solidInCsharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase {
        private readonly ILogger<ProdutoController> _logger;
		private readonly IProdutoReportService produtoReportService;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoReportService produtoReportService)
        {
            _logger = logger;
			this.produtoReportService = produtoReportService;
        }

		[HttpGet]
		[Authorize]
		public ActionResult<string> RelatorioProdutos([FromQuery]TipoRelatorio tipoRelatorio)
		{
			return produtoReportService.GerarRelatorio(ReportGeneratorFactory.ObterGerador(tipoRelatorio));
		}
    }
}
