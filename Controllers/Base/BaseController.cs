using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace desafio_lynx_process.Controllers.Base
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseController : ControllerBase
    {
        [HttpGet("ping")]
        public async Task<IActionResult> PingServer()
        {
            return Ok(new {Message= "Server is online"});
        }

    }
}