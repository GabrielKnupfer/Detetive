using Detetive.Application.Interfaces;
using Detetive.Domain.Entities;
using Detetive.Domain.Repositories;
using System.Collections.Generic;


namespace Detetive.Application.Implementations
{
    public class SuspeitoAppService : ISuspeitoAppService
    {
        readonly ISuspeitoRepository _repository;

        public SuspeitoAppService(ISuspeitoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Suspeito> Obter()
        {
            return _repository.Get();
        }
    }
}
