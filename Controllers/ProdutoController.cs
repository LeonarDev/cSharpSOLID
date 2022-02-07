﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using solidInCsharp.Service;
using solidInCsharp.Service.Report;
using Microsoft.AspNetCore.Authorization;

namespace solidInCsharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase {
        private readonly ILogger<ProdutoController> _logger;
		private readonly ProdutoReportService produtoReportService;

        public ProdutoController(ILogger<ProdutoController> logger, ProdutoReportService produtoReportService)
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
