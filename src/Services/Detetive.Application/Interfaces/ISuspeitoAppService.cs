using Detetive.Domain.Entities;
using System.Collections.Generic;

namespace Detetive.Application.Interfaces
{
    public interface ISuspeitoAppService
    {
        IEnumerable<Suspeito> Obter();
    }
}
