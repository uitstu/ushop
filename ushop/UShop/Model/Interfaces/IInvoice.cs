using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IInvoice
    {
        bool addInvoice(INVOICE invoice,List<INVOICE_ITEM> itemList);
        bool updateInvoice(INVOICE updatedInvoice, List<INVOICE_ITEM> itemList);
        bool deleteInvoice(int id);
        bool deleteInvoice(String code);
        INVOICE getInvoiceByCode(String code,RECORD_STATUS status);
        int getInvoiceCount();
        List<INVOICE> getInvoicesBy(String byEmployee , String date, RECORD_STATUS status);
        List<String> getProductNameBy(RECORD_STATUS status);
        List<CUSTOMER> getCustomerBy(RECORD_STATUS status);
        //DataTable getProductsBy(RECORD_STATUS status);
        List<PRODUCT> getProductsBy(RECORD_STATUS status);
        List<PRODUCT_SIZE> getProductSizeBy(int proid, RECORD_STATUS status);
        DataTable getInvoiceListBy(int empId, String date, RECORD_STATUS status);

        DataTable getInvoiceItemListBy(int invoiceId, RECORD_STATUS status);
        List<INVOICE_ITEM>  getInvoiceItems(int invoiceId);
    }
}
