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
    public class CategoryPresenter
    {
        private CategoryModel _model;
        private ICategoryView _view;

        public CategoryPresenter()
        { 
        }

        public CategoryPresenter(ICategoryView view)
            : this(view, new CategoryModel())
        {
        }

        public CategoryPresenter(ICategoryView view, CategoryModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadCategories()
        {
            _view.loadCategories(_model.loadCategory());
        }

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
    }
}
