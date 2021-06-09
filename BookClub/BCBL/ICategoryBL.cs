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
        Category AddCategory(Category category);

        List<Category> GetAllCategories();

        Category GetCategory(string name);

        Category DeleteCategory(string name);
    }
}
