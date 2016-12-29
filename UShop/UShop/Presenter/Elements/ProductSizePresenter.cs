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
    public class ProductSizePresenter
    {
        private ProductSizeModel _model;
        private IProductSizeView _view;

        public ProductSizePresenter()
        { 
        }

        public ProductSizePresenter(IProductSizeView view)
            : this(view, new ProductSizeModel())
        {
        }

        public ProductSizePresenter(IProductSizeView view, ProductSizeModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadProductSizes()
        {
            _view.loadProductSizes(_model.loadProductSize());
        }

        public void saveProductSize(PRODUCT_SIZE obj)
        {
            _model.addProductSize(obj);
            _view.loadProductSizes(_model.loadProductSize());
        }

        public void deleteProductSize(String id, string size)
        {
            _model.deleteProductSize(id,size);
            _view.loadProductSizes(_model.loadProductSize());
        }

        public void updateProductSize(PRODUCT_SIZE obj)
        {
            _model.updateProductSize(obj);
            _view.loadProductSizes(_model.loadProductSize());
        }

        public DataTable loadProductDT(bool isAll)
        {
            return _model.loadProductDT(isAll);
        }

        public List<String> getLstSize(int productID)
        {
            return _model.getLstSize(productID);
        }
    }
}
