﻿using Model;
using Model.InterfaceImplement;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presenter.InterfaceImplement
{
    public class ReceiptNotePresenter
    {
        private ReceiptNoteModel _model;
        private IReceiptNoteView _view;

        public ReceiptNotePresenter()
        { 
        }

        public ReceiptNotePresenter(IReceiptNoteView view)
            : this(view, new ReceiptNoteModel())
        {
        }

        public ReceiptNotePresenter(IReceiptNoteView view, ReceiptNoteModel model)
        {
            _view = view;
            _model = model;
        }


        public void loadReceiptNotes()
        {
            _view.loadReceiptNotes(_model.loadReceiptNote());
        }

        public void loadReceiptNotesDB()
        {
            _view.loadReceiptNotesDB(_model.loadReceiptNoteDT());
        }

        /*
        public void saveCategory(Category obj)
        {
            _model.addCategory(obj);
            _view.loadCategories(_model.loadCategory());
        }

        public void deleteCategory(String id)
        {
            _model.deleteCategory(id);
            _view.loadCategories(_model.loadCategory());
        }

        public void updateCategory(Category obj)
        {
            _model.updateCategory(obj);
            _view.loadCategories(_model.loadCategory());
        }
        */

        public DataTable loadSupplierDT()
        {
            return _model.loadSupplierDT();
        }

        public DataTable loadProdcutDT()
        {
            return _model.loadProductDT();
        }
    }


}
