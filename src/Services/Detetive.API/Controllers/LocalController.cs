using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Detetive.Application.Interfaces;
using Detetive.API.Models;
using System.Collections.Generic;

namespace Detetive.API.Controllers
{
    [Route("api/[controller]")]
    public class LocalController : Controller
    {
        readonly ILocalAppService _appService;

        public LocalController(ILocalAppService appService)
        {
            _appService = appService;
        }

        [HttpGet, Route("Get")]
        public IEnumerable<LocalViewModel> Get()
        {
            return _appService.Obter().Select(x => new LocalViewModel(x)).ToList();
        }
    }
}
