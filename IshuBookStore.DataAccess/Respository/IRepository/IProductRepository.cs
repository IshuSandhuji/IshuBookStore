using IshuBooks.Models;
using IshuBookStore.DataAccess.Repository;
using IshuBookStore.DataAccess.Respository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IshuBookStore.DataAccess.Repository.IRepository
{
    public interface IProductRepositroy : IRepository<Product>
    {
        void Update(Product product);
    }
}
