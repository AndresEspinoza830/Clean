using Clean.Application.Interfaces;
using Clean.Domain.Entities;
using MediatR;


namespace Clean.Application.Handlers.Queries.PersonController
{
    public class QueryFindAll : IRequest<List<Person>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<Person>>
        {
            private readonly IUnitOfWork _unit;

            public QueryFindAllHandler(IUnitOfWork unit)
            {
                _unit = unit;
            }

            public async Task<List<Person>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                return await _unit.Persons.FindAll();
            }
        }
    }
}