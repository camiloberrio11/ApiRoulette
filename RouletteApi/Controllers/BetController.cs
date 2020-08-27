using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RouletteApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class BetController : ControllerBase
    {
        [Route("bets/{idroulette}")]
        [HttpGet]
        public IActionResult getBetsByRouletteController(int idroulette)
        {
            return Ok(idroulette);
        }
        [Route("betroulette")]
        [HttpPost]
        public IActionResult BetOnRouletteController()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}
