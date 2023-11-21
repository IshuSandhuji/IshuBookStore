using IshuBookStore.DataAccess.Data;
using IshuBookStore.DataAccess.Respository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshuBookStore.DataAccess.Respository
{
    public class UnitOFWork : UnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOFWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);


        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepositroy CoverType { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
