using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;

namespace Detetive.Infrastructure.Repositories
{
    public class SuspeitoRepository : Repository<Suspeito>, ISuspeitoRepository
    {
        public SuspeitoRepository(DetetiveContext context) : base(context)
        {
        }
    }
}
