using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly BookClubDBContext _context;

        public CategoryRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<Category> AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.AsNoTracking().Select(cat => cat).ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(string name)
        {
            return await _context.Categories.AsNoTracking().FirstOrDefaultAsync(cat => cat.CategoryId.Equals(name));
        }
    }
}
