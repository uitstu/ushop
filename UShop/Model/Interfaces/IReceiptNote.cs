using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IReceiptNote
    {
        List<RECEIPT_NOTE> loadReceiptNote();
        void addReceiptNote(RECEIPT_NOTE obj);
        void deleteReceiptNote(String id);
        void updateReceiptNote(RECEIPT_NOTE obj);

        RECEIPT_NOTE findReceiptNote(String id);

        DataTable loadReceiptNoteDT();

        DataTable loadSupplierDT();
        DataTable loadProductDT();

        void add(RECEIPT_NOTE obj, DataTable dtItems);

        PRODUCT getProductByCODE(string code);
    }
}
