using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class CategoryBL : ICategoryBL
    {
        private readonly ICategoryRepo _repo;

        public CategoryBL(ICategoryRepo repo)
        {
            _repo = repo;
        }

        public Category AddCategory(Category category)
        {
            return _repo.AddCategory(category);
        }

        public Category DeleteCategory(string name)
        {
            return _repo.DeleteCategory(name);
        }

        public List<Category> GetAllCategories()
        {
            return _repo.GetAllCategories();
        }

        public Category GetCategory(string name)
        {
            return _repo.GetCategory(name);
        }
    }
}
