using Clean.Application.Handlers.Queries.CountryController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("FindAll",Name ="Deveulve todos los paises")]
        public async Task<IActionResult> FindAll()
        {
            var response = await _mediator.Send(new QueryFindAll());
            return Ok(response);
        }
    }
}
