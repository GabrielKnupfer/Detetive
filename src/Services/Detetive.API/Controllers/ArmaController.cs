using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Detetive.Application.Interfaces;
using Detetive.API.Models;

namespace Detetive.API.Controllers
{
    [Route("api/[controller]")]
    public class ArmaController : Controller
    {
        readonly IArmaAppService _appService;

        public ArmaController(IArmaAppService appService)
        {
            _appService = appService;
        }

        [HttpGet, Route("Get")]
        public IEnumerable<ArmaViewModel> Get()
        {
            return _appService.Obter().Select(x => new ArmaViewModel(x)).ToList();
        }

    }
}
