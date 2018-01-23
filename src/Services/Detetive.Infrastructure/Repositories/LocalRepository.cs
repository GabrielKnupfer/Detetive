using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;

namespace Detetive.Infrastructure.Repositories
{
    public class LocalRepository : Repository<Local>, ILocalRepository
    {
        public LocalRepository(DetetiveContext context) : base(context)
        {
        }
    }
}
