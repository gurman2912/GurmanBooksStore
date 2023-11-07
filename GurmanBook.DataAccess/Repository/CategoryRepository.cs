using GurmanBook.DataAccess.Repository.IRepository;
using GurmanBooksStore.DataAccess.Data;
using GurmanBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GurmanBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(Category category)
        {
                //us .NET LINQ to retrieve the first or default category object,
                //thn pass the id as a generic entity which matches the category ID
                var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
                if (objFromDb != null) //save changes if not null 
                {
                    objFromDb.Name = category.Name;
                    _db.SaveChanges();
                }
            
            throw new NotImplementedException();
        }
    }
}
