using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly BookClubDBContext _context;

        public CategoryRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.Select(cat => cat).ToList();
        }

        public Category GetCategory(string name)
        {
            return _context.Categories.FirstOrDefault(cat => cat.CategoryId.Equals(name));
        }

        public Category DeleteCategory(string name)
        {
            Category toBeDeleted = _context.Categories.FirstOrDefault(cat => cat.CategoryId.Equals(name));

            if (toBeDeleted != null)
            {
                _context.Categories.Remove(toBeDeleted);
                _context.SaveChanges();
            }

            return toBeDeleted;

        }
    }
}
