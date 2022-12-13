using Spotlight.Entities;

namespace Spotlight.Persistence.Repositories.ShowRepository;

public class ShowRepository : Repository<Show>, IShowRepository
{
    private readonly SpotlightContext _context;

    public ShowRepository(SpotlightContext context) : base(context)
    {
        _context = context;
    }

}
