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
        bool addInvoice(INVOICE invoice);
        bool updateInvoice(INVOICE updatedInvoice);
        bool deleteInvoice(int id);
        bool deleteInvoice(String code);
        INVOICE getInvoiceByCode(String code);
        int getInvoiceCount();
        List<INVOICE> getInvoicesBy(String byEmployee , String date, RECORD_STATUS status);
        List<String> getProductNameBy(RECORD_STATUS status);
        List<String> getCustomerNameBy(RECORD_STATUS status);
        //DataTable getProductsBy(RECORD_STATUS status);
        List<PRODUCT> getProductsBy(RECORD_STATUS status);
        List<PRODUCT_SIZE> getProductSizeBy(int proid, RECORD_STATUS status);
        DataTable getInvoiceListBy(int empId, String date, RECORD_STATUS status);
        List<INVOICE_ITEM>  getInvoiceItems(int invoiceId);
    }
}
