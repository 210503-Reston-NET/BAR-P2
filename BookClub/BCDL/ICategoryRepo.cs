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
        Category AddCategory(Category category);

        List<Category> GetAllCategories();

        Category GetCategory(string name);

        Category DeleteCategory(string name);
    }
}
