using GurmanBook.DataAccess.Repository.IRepository;
using GurmanBooksStore.DataAccess.Data;
using GurmanBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
