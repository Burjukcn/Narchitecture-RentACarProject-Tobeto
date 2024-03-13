

namespace NarchitectureCorePersistence.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}
