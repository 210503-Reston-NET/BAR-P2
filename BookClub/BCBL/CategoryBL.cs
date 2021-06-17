using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class CategoryBL : ICategoryBL
    {
        private readonly ICategoryRepo _repo;

        public CategoryBL(ICategoryRepo repo)
        {
            _repo = repo;
        }

        public async Task<Category> AddCategoryAsync(Category category)
        {
            return await _repo.AddCategoryAsync(category);
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _repo.GetAllCategoriesAsync();
        }

        public async Task<Category> GetCategoryAsync(string name)
        {
            return await _repo.GetCategoryAsync(name);
        }
    }
}
