using Detetive.Domain.Entities;
using System.Collections.Generic;

namespace Detetive.Application.Interfaces
{
    public interface ILocalAppService
    {
        IEnumerable<Local> Obter();
    }
}
