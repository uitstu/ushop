using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IReceiptNoteView
    {
        void loadReceiptNotes(List<RECEIPT_NOTE> listObj);
        //void saveCategory(Category obj);
        //void deleteCategory(String id);

        void loadReceiptNotesDB(DataTable dt);

    }
}
