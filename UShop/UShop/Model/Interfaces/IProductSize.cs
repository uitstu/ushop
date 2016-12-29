using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IProductSize
    {
        DataTable loadProductSize();
        void addProductSize(PRODUCT_SIZE obj);
        void deleteProductSize(string id, string size);
        void updateProductSize(PRODUCT_SIZE obj);
        DataTable loadProductDT(bool isAll);

        List<String> getLstSize(int productID);
    }
}
