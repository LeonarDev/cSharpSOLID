using System.Collections.Generic;

namespace solidInCsharp.Interface
{
    public interface IReadRepository<T> where T : class
    {
		    public IEnumerable<T> ListAll();
    }
}
