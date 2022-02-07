using solidInCsharp.Repository;
using solidInCsharp.Service.Interface;
using solidInCsharp.Service.Report;

namespace solidInCsharp.Service
{
    public class ProdutoReportService : IProdutoReportService
    {
		private ProdutoRepository Repository;

        public ProdutoReportService(ProdutoRepository repository) {
			Repository = repository;
		}

		public string GerarRelatorio(IReportGenerator generator) {
			var produtos = Repository.ListAll();
			generator.IniciarRelatorio();
			generator.IniciarHeaders();
			generator.AdicionarHeader("ID");
			generator.AdicionarHeader("Nome");
			generator.AdicionarHeader("Preço");
			generator.FinalizarHeaders();
			foreach (var produto in produtos)
			{
				generator.IniciarLinha();
				generator.AdicionarHeader(produto.Id);
				generator.AdicionarHeader(produto.Nome);
				generator.AdicionarHeader(produto.Preco + "");
				generator.FinalizarLinha();
			}
			return generator.FinalizarRelatorio();
		}
    }
}
