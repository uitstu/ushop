using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface ICategory
    {
        List<CATEGORY> loadCategory();
        void addCategory(CATEGORY obj);
        void deleteCategory(String id);
        void updateCategory(CATEGORY obj);
    }
}
