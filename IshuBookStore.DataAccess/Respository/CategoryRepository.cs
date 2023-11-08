using IshuBooks.Models;
using IshuBookStore.DataAccess.Data;
using IshuBookStore.DataAccess.Respository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshuBookStore.DataAccess.Respository
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) {
            {
                _db = db;
            }



        }

        void ICategoryRepository.Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb == null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
            throw new NotImplementedException();
        }
    } }