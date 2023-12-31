﻿using IshuBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshuBookStore.DataAccess.Respository.IRepository
{
     interface UnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepositroy CoverType { get; }
        IProductRepositroy Product { get; }

        ISP_Call SP_Call { get; }

        void Save();
    }
}
