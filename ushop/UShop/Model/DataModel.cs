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

        public String getCODE(String frefix, int id)
        {
            String code = "" + frefix;

            String strNumber = Convert.ToString(id);

            for (int i = 6 - strNumber.Length; i > 0; i--)
            {
                code += "0";
            }

            code += strNumber;

            return code;
        }
    }
}
