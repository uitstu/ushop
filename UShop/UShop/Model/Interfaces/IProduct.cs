using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IProduct
    {
        List<PRODUCT> loadProduct();
        void addProduct(PRODUCT obj);
        void deleteProduct(String id);
        void updateProduct(PRODUCT obj);
        DataTable loadCategoryDT(bool isAll);
        DataTable loadProductList();
    }
}
