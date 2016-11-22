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
    public class ProductCategoryPresenter
    {
        private ProductCategoryModel _model;
        private IProductCategoryView _view;

        public ProductCategoryPresenter()
        { 
        }

        public ProductCategoryPresenter(IProductCategoryView view)
            : this(view, new ProductCategoryModel())
        {
        }

        public ProductCategoryPresenter(IProductCategoryView view, ProductCategoryModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadProductCategories()
        {
            _view.loadProductCategories(_model.loadProductCategory());
        }
    }
}
