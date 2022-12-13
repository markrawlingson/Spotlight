using Spotlight.Persistence.Repositories.ShowRepository;

namespace Spotlight.Persistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly SpotlightContext _context;

    public UnitOfWork(SpotlightContext context)
    {
        _context = context;

        Shows = new ShowRepository(_context);
    }

    public IShowRepository Shows { get; }

    public async Task<int> Complete()
    {
        var response = await _context.SaveChangesAsync();
        return response;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
