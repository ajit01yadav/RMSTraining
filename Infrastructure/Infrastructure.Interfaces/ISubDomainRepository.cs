﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ISubDomainRepository<T> : IBaseRepository<T> where T : class
    {

    }
}
