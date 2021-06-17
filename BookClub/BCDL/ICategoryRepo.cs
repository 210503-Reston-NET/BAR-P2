using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface ICategoryRepo
    {
        Task<Category> AddCategoryAsync(Category category);

        Task<List<Category>> GetAllCategoriesAsync();

        Task<Category> GetCategoryAsync(string name);
    }
}
