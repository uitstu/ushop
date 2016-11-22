using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface ICategoryView
    {
        void loadCategories(List<Category> listObj);
        //void saveCategory(Category obj);
        //void deleteCategory(String id);
    }
}
