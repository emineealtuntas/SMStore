using Microsoft.EntityFrameworkCore;
using SMStore.Data;
using SMStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMStore.Service.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<Category> KategoriyiUrunleriyleGetir(int categoryId)
        {
            return await _databaseContext.Categories.Include(c=>c.Products).FirstOrDefaultAsync(c=>c.Id == categoryId);
        }
    }
}
