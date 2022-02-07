using System.Collections.Generic;

namespace solidInCsharp.Repository.Interface
{
    public interface IReadRepository<T> where T : class
    {
		    public IEnumerable<T> ListAll();
    }
}
