namespace solidInCsharp.Interface
{
    public interface IReadWriteRepository<T> : IReadRepository<T>, IWriteRepository<T>
        where T : class
    { }
}
