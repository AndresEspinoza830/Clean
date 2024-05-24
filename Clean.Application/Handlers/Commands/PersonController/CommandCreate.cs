using Clean.Application.Interfaces;
using Clean.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Handlers.Commands.PersonController
{
    public class CommandCreate: IRequest<Person>
    {
        public Person Person { get; set; }
        public CommandCreate(Person person)
        {
            Person = person;
        }

        public class CommandCreateHandler : IRequestHandler<CommandCreate, Person>
        {
            private readonly IUnitOfWork _unit;

            public CommandCreateHandler(IUnitOfWork unit)
            {
                _unit = unit;
            }

            public async Task<Person> Handle(CommandCreate request, CancellationToken cancellationToken)
            {
                var person = request.Person;
                _unit.Persons.Create(person);
                await _unit.SaveChangesAsync();
                return person;
            }
        }
    }
}
