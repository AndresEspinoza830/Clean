using Clean.Application.Interfaces;
using Clean.Domain.Entities;
using Clean.Infrastucture.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastucture.Repository
{
    public class UnitOfWork :  IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public IGenericRepository<Person> Persons => this._serviceProvider.GetRequiredService<IGenericRepository<Person>>();


    
    }
}
