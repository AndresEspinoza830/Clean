﻿using Clean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Person> Persons { get; }

    }
}
