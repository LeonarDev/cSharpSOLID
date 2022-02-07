using solidInCsharp.Service.Report;

namespace solidInCsharp.Service.Interface
{
    public interface IProdutoReportService
    {
        public string GerarRelatorio(IReportGenerator generator);
    }
}
