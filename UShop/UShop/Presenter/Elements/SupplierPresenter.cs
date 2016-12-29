using Model;
using Model.InterfaceImplement;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.InterfaceImplement
{
    public class SupplierPresenter
    {
        private SupplierModel _model;
        private ISupplierView _view;

        public SupplierPresenter()
            : this(null , new SupplierModel())
        { 
        }

        public SupplierPresenter(ISupplierView view)
            : this(view, new SupplierModel())
        {
        }

        public SupplierPresenter(ISupplierView view, SupplierModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadSuppliers()
        {
            _view.loadSuppliers(_model.loadSupplier());
        }

        public void saveSupplier(SUPPLIER obj)
        {
            _model.addSupplier(obj);
            if (_view != null)
                _view.loadSuppliers(_model.loadSupplier());
        }

        public void deleteSupplier(String id)
        {
            _model.deleteSupplier(id);
            _view.loadSuppliers(_model.loadSupplier());
        }

        public void updateSupplier(SUPPLIER obj)
        {
            _model.updateSupplier(obj);
            _view.loadSuppliers(_model.loadSupplier());
        }
    }
}
