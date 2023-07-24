using ExampleProject.Core.Entities;
using ExampleProject.Data.Repositories.Abstrations;

namespace ExampleProject.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();

        int Save();
    }
}
