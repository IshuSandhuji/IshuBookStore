using IshuBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshuBookStore.DataAccess.Respository.IRepository
{
    public interface ICoverTypeRepositroy : IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
