using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorSample.Application;
using MediatorSample.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TimeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Jogador>>> Post([FromBody] SubstituirJogadorCommand command)
        {
            var resultado = await _mediator.Send(command);
            return Ok(resultado);
        }
    }
}