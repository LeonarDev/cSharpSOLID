namespace solidInCsharp.Service.Interface
{
    public interface ICriptografiaService
    {
        public bool ValidarSenha(string senhaCripto, string senhaDigitada);
        public string CriptografarSenha(string senha);
    }
}
