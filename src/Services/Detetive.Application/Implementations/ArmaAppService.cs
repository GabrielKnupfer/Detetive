using Detetive.Application.Interfaces;
using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;
using System.Collections.Generic;

namespace Detetive.Application.Implementations
{
    public class ArmaAppService : IArmaAppService
    {
        readonly IArmaRepository _repository;

        public ArmaAppService(IArmaRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Arma> Obter()
        {
            return _repository.Get();
        }
    }
}
