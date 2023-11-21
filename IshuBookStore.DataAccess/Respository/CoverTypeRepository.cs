using IshuBooks.Models;
using IshuBookStore.DataAccess.Data;
using IshuBookStore.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshuBookStore.DataAccess.Respository.IRepository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepositroy
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }


        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }

        }


    }
}

