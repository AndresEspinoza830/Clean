using Clean.Application.Interfaces;
using Clean.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Handlers.Queries.CountryController
{
    public class QueryFindAll : IRequest<List<Country>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<Country>>
        {
            private readonly IUnitOfWork _unit;

            public QueryFindAllHandler(IUnitOfWork unit)
            {
                _unit = unit;
            }

            public async Task<List<Country>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                return await _unit.Country.FindAll();
            }
        }
    }

}
