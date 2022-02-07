## Liskov Substitution Principle

O **Princípio de Substituição de [Liskov](https://www.google.com/search?q=barbara+liskov&oq=barbara+liskov&aqs=chrome..69i57.4378j0j1&sourceid=chrome&ie=UTF-8)**, diz que as classes bases devem ser substituídas pelas classes derivadas em todos os contextos, ou seja, uma classe derivada não pode modificar o "contrato" da classe base.

Nosso projeto viola esse princípio na classe `ProdutoRepository`:

```C#
namespace solidInCsharp.Repository
{
    public class ProdutoRepository: BaseRepository<Produto, ProdutoRepository>
    {
        // Código omitido
        public new void Add(Produto item) {
            throw new Exception("Products are readonly");
        }

        public new void Update(Produto item) {
            throw new Exception("Products are readonly");
        }

        public new void Remove(Produto item) {
            throw new Exception("Products are readonly");
        }
    }
}
```

Ao sobrescrever os métodos e fazer eles lançarem excessão, a classe `ProdutoRepository` não pode substituir a classe `BaseRepository` em todas as suas atribuições.

Para corrigir, criamos uma nova classe `BaseReadOnlyRepository` que somente possui o método de leitura e alteramos o `ProdutoRepository` para herdar desta classe.

```C#
namespace solidInCsharp.Repository
{
    public abstract class BaseReadOnlyRepository<T,K> : DbContext where T : class  where K : BaseReadOnlyRepository<T,K>
    {
        public BaseReadOnlyRepository(DbContextOptions<K> options)
            : base(options)
        { }
        protected DbSet<T> Items { get; set; }
        public IEnumerable<T> ListAll() => this.Items.ToArray();
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using solidInCsharp.Model;
using System.Linq;

namespace solidInCsharp.Repository
{
    public class ProdutoRepository: BaseReadOnlyRepository<Produto, ProdutoRepository>
    {
        public ProdutoRepository(DbContextOptions<ProdutoRepository> options)
            : base(options)
        {
            // trecho omitido
        }
    }
}
```

Com isso, nossa classe não mais ofende o LSP.
