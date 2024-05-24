using Clean.Application.Handlers.Commands.PersonController;
using Clean.Application.Handlers.Queries.PersonController;
using Clean.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("FindAll", Name ="Obtiene todos las personas")]
        public async Task<IActionResult> FindAll()
        {
            var response = await _mediator.Send(new QueryFindAll());
            return  Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Person person)
        {
           return Ok( await _mediator.Send(new CommandCreate(person)));
        }
    }
}
