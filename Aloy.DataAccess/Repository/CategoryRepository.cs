using Aloy.DataAccess.Data;
using Aloy.DataAccess.Repository.IRepository;
using Aloy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aloy.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public int Counting()
        {
            return _db.Categories.Count();
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
