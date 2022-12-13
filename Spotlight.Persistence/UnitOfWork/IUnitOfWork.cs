using Spotlight.Persistence.Repositories.ShowRepository;

namespace Spotlight.Persistence.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IShowRepository Shows { get; }

    Task<int> Complete();
}