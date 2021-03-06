using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface ICategoryBL
    {
        Task<Category> AddCategoryAsync(Category category);

        Task<List<Category>> GetAllCategoriesAsync();

        Task<Category> GetCategoryAsync(string name);
    }
}
