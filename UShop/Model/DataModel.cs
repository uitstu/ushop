using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataModel
    {
        protected UShopDBDataContext UShopDB;

        public DataModel()
        {
            if (UShopDB == null)
                UShopDB = new UShopDBDataContext();
        }
    }
}
