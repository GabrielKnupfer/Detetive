using Detetive.Application.Interfaces;
using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;
using System.Collections.Generic;

namespace Detetive.Application.Implementations
{
    public class LocalAppService : ILocalAppService
    {
        readonly ILocalRepository _repository;

        public LocalAppService(ILocalRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Local> Obter()
        {
            return _repository.Get();
        }
    }
}
