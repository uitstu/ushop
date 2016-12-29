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

        RECEIPT_NOTE getReceiptNoteByCODE(String code);

        DataTable loadReceiptNoteDT();

        DataTable loadSupplierDT(bool isAll);
        DataTable loadProductDT();

        void add(RECEIPT_NOTE obj, DataTable dtItems);

        PRODUCT getProductByCODE(string code);

        DataTable loadRN_ITEM(int RN_ID);

        string update(RECEIPT_NOTE obj, DataTable dtItems);
    }
}
