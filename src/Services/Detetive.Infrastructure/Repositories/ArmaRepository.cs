using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;

namespace Detetive.Infrastructure.Repositories
{
    public class ArmaRepository : Repository<Arma>, IArmaRepository
    {
        public ArmaRepository(DetetiveContext context) : base(context)
        {
        }
    }
}
