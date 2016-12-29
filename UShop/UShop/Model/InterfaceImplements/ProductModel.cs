using Model.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class ProductModel : DataModel, IProduct
    {
        public List<Model.PRODUCT> loadProduct()
        {
            return UShopDB.PRODUCTs.Where(o => o.RECORD_STATUS.Equals("A")).ToList();
        }

        public DataTable loadProductList()
        {
            var result = from p in UShopDB.PRODUCTs
                         join c in UShopDB.CATEGORies
                         on p.CATEGORY_ID equals c.CATEGORY_ID
                         into final1
                         from x in final1.DefaultIfEmpty()

                         select new
                         {
                             p.PRODUCT_ID,
                             p.PRODUCT_CODE,
                             p.PRODUCT_NAME,
                             p.CATEGORY_ID,
                             x.CATEGORY_NAME,
                             p.UNIT,
                             p.SELLING_PRICE,
                             p.COST_PRICE,
                             p.SALE_AMOUNT,
                             p.DESCRIPTION,
                             p.PRODUCER,
                             p.ORIGIN,
                             p.RECORD_STATUS,
                             
                         };

            DataTable dt = new DataTable();
            dt.Columns.Add("PRODUCT_ID");
            dt.Columns.Add("PRODUCT_CODE");
            dt.Columns.Add("PRODUCT_NAME");
            dt.Columns.Add("CATEGORY_ID");
            dt.Columns.Add("CATEGORY_NAME");
            dt.Columns.Add("UNIT");
            dt.Columns.Add("SELLING_PRICE");
            dt.Columns.Add("COST_PRICE");
            dt.Columns.Add("SALE_AMOUNT");
            dt.Columns.Add("DESCRIPTION");
            dt.Columns.Add("PRODUCER");
            dt.Columns.Add("ORIGIN");
            dt.Columns.Add("RECORD_STATUS");

            //dt.Columns.Add("RECORD_STATUS");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.PRODUCT_ID, o.PRODUCT_CODE, o.PRODUCT_NAME, o.CATEGORY_ID, o.CATEGORY_NAME
                    , o.UNIT, o.SELLING_PRICE, o.COST_PRICE, o.SALE_AMOUNT, o.DESCRIPTION, o.PRODUCER
                    , o.ORIGIN, o.RECORD_STATUS);
            }

            return dt;
        }

        public void addProduct(PRODUCT obj)
        {
            try
            {
                UShopDB.PRODUCTs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
                obj.PRODUCT_CODE = getCODE("PRO",obj.PRODUCT_ID);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteProduct(string id)
        {
            PRODUCT obj = UShopDB.PRODUCTs.Where(o => o.PRODUCT_ID == Convert.ToInt32(id)).SingleOrDefault();
            obj.RECORD_STATUS = "D";

            foreach (PRODUCT_SIZE z in UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == Convert.ToInt32(id)))
            {
                UShopDB.PRODUCT_SIZEs.DeleteOnSubmit(z);
            }

            UShopDB.SubmitChanges();
        }


        public void updateProduct(PRODUCT product)
        {
            PRODUCT obj = UShopDB.PRODUCTs.Where(o => o.PRODUCT_ID == Convert.ToInt32(product.PRODUCT_ID)).SingleOrDefault();
            obj.CATEGORY_ID = product.CATEGORY_ID;
            obj.PRODUCT_NAME = product.PRODUCT_NAME;
            obj.UNIT = product.UNIT;
            obj.SELLING_PRICE = product.SELLING_PRICE;
            obj.COST_PRICE = product.COST_PRICE;
            obj.SALE_AMOUNT = product.SALE_AMOUNT;
            obj.DESCRIPTION = product.DESCRIPTION;
            obj.PRODUCER = product.PRODUCER;
            obj.ORIGIN = product.ORIGIN;

            UShopDB.SubmitChanges();
        }

        //

        public DataTable loadCategoryDT(bool isAll)
        {
            var result = from r in UShopDB.CATEGORies
                         select new
                         {
                             r.CATEGORY_CODE,
                             r.CATEGORY_NAME,
                             r.RECORD_STATUS
                         };

            DataTable dt = new DataTable();

            dt.Columns.Add("CATEGORY_CODE");
            dt.Columns.Add("CATEGORY_NAME");
            dt.Columns.Add("RECORD_STATUS");

            if (isAll)
            {
                foreach (var o in result)
                {
                    dt.Rows.Add(o.CATEGORY_CODE, o.CATEGORY_NAME, o.RECORD_STATUS);
                }
            }
            else
            {
                foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
                {
                    dt.Rows.Add(o.CATEGORY_CODE, o.CATEGORY_NAME, o.RECORD_STATUS);
                }
            }

            return dt;
        }
    }
}
