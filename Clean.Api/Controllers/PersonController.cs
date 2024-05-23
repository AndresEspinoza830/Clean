using Clean.Application.Handlers.Queries.PersonController;
using Clean.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
        public PersonController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        [HttpGet("FindAll", Name ="Obtiene todos las personas")]
        public async Task<IActionResult> FindAll()
        {
            var response = await _mediator.Send(new QueryFindAll());
            return  Ok(response);
        }
    }
}
