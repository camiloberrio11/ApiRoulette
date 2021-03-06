﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RouletteApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        [Route("roulettes")]
        [HttpGet]
        public IActionResult RouleteListController()
        {
            return Ok(new string[] { "value1", "value2" });
        }
        [Route("addroulette")]
        [HttpPost]
        public IActionResult SaveRouletteController()
        {
            return Ok(new string[] {  "saludo", "Hola" });
        }
        [Route("closeroulette/{idroulette}")]
        [HttpPut]
        public IActionResult CloseRouletteController(int idroulette)
        {
            return Ok(new string[] { "saludo", "Hola" });
        }
        [Route("openroulette/{idroulette}")]
        [HttpPut]
        public IActionResult OpenRouletteController(int idroulette)
        {
            return Ok(new string[] { "saludo", "Hola" });
        }
    }
}
