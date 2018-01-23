using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Detetive.Application.Interfaces;
using Detetive.API.Models;
using System.Collections.Generic;

namespace Detetive.API.Controllers
{
    public class SuspeitoController : Controller
    {
        readonly ISuspeitoAppService _appService;

        public SuspeitoController(ISuspeitoAppService appService)
        {
            _appService = appService;
        }

        [HttpGet, Route("Get")]
        public IEnumerable<SuspeitoViewModel> Get()
        {
            return _appService.Obter().Select(x => new SuspeitoViewModel(x)).ToList();
        }
    }
}
