## Dependency Inversion Principle

O [**Princípio de Inversão de Dependencia**](https://pt.stackoverflow.com/questions/101552/o-que-%C3%A9-princ%C3%ADpio-da-invers%C3%A3o-de-depend%C3%AAncia-dip) diz que nossas classes sempre devem depender de abstrações e não de concretos.

Seguindo esse principio favorecemos vários pontos importantes nos projetos, como a melhoria de manutenibilidade, testabilidade e extensabilidade do código.

Nosso projeto viola esse princípio em vários pontos, que listamos a seguir:

* Controllers dependem de services diretamente
* Services tem dependencia de outros services diretamente
* Services constroem outros services

Para resolução destes pontos, devemos criar interfaces e em .Net o meio mais fácil é fazer a injeção de dependencias. Por exemplo, na classe `UsuarioService`:

```C#
nomespace solidInCsharp.Service
{
    public class UsuarioService
    {
        private IUsuarioRepository Repository;

        public UsuarioService(IUsuarioRepository repository)
        { 
            Repository = repository;
        }

        public void CriarUsuario(string email, string nome, string senha)
        {
            var usuario = Repository.ObterUsuario(email);
            if (usuario != null) {
                throw new Exception("Erro, usuário já existe");
            }
            usuario = new Usuario() { Email = email, Nome = nome, Senha = new CriptografiaService().CriptografarSenha(senha)};
            Repository.Add(usuario);
        }

        public string Login(string email,  string senha)
        {
            var usuario = Repository.ObterUsuario(email);
            if (usuario == null || !new CriptografiaService().ValidarSenha(usuario.Senha, senha)) {
                throw new Exception("Erro, usuário ou senha incorreto");
            }
            return new JWTService().GerarToken(usuario);
        }
    }
}
```

Nesta classe, precisamos isolar a criação do `JWTService` e `CriptografiaService`, além de criar uma interface para ela que permitirá que os controllers não tenham uma dependencia direta da implementação.

A implementação desta classe fica desta forma:

```C#
nomespace solidInCsharp.Service
{
    public class UsuarioService: IUsuarioService
    {
        private IUsuarioRepository Repository;
        private ICriptografiaService CriptografiaService;
        private IJWTService JWTService;

        public UsuarioService(IUsuarioRepository repository, ICriptografiaService criptografia, IJWTService jwtService){ 
            Repository = repository;
            CriptografiaService = criptografia;
            JWTService = jwtService;
        }

        public void CriarUsuario(string email, string nome, string senha) {
            var usuario = Repository.ObterUsuario(email);
            if (usuario != null) {
                throw new Exception("Erro, usuário já existe");
            }
            usuario = new Usuario() { Email = email, Nome = nome, Senha = CriptografiaService.CriptografarSenha(senha)};
            Repository.Add(usuario);
        }

        public string Login(string email,  string senha) {
            var usuario = Repository.ObterUsuario(email);
            if (usuario == null || !CriptografiaService.ValidarSenha(usuario.Senha, senha)) {
                throw new Exception("Erro, usuário ou senha incorreto");
            }
            return JWTService.GerarToken(usuario);
        }
    }
}
```

Por fim, fazemos ajuste na classe de `Startup` para permitir a injeção de dependencias.

```C#
namespace solidInCsharp
{
    public class Startup
    {
        // Codigo omitido

        public void ConfigureServices(IServiceCollection services)
        {
            // Codigo omitido

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddScoped<ICriptografiaService, CriptografiaService>();
            services.AddScoped<IJWTService, JWTService>();

            services.AddScoped<IUsuarioService, UsuarioService>();
			services.AddScoped<IProdutoReportService, ProdutoReportService>();
        }
        
        // Codigo omitido
    }
```
