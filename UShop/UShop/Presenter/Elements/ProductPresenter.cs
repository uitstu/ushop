using Model;
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
    public class ProductPresenter
    {
        private ProductModel _model;
        private IProductView _view;

        public ProductPresenter()
            : this(null, new ProductModel())
        { 
        }

        public ProductPresenter(IProductView view)
            : this(view, new ProductModel())
        {
        }

        public ProductPresenter(IProductView view, ProductModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadProducts()
        {
            _view.loadProducts(_model.loadProduct());
        }

        public void loadProductList()
        {
            _view.loadProductList(_model.loadProductList());
        }

        public void saveProduct(PRODUCT obj)
        {
            _model.addProduct(obj);
            if (_view != null)
                //_view.loadProducts(_model.loadProduct());
                _view.loadProductList(_model.loadProductList());
        }

        public void deleteProduct(String id)
        {
            _model.deleteProduct(id);
            //_view.loadProducts(_model.loadProduct());
            _view.loadProductList(_model.loadProductList());
        }

        public void updateProduct(PRODUCT obj)
        {
            _model.updateProduct(obj);
            //_view.loadProducts(_model.loadProduct());
            _view.loadProductList(_model.loadProductList());
        }

        public DataTable loadCategoryDT(bool isAll)
        {
            return _model.loadCategoryDT(isAll);
        }
    }
}
