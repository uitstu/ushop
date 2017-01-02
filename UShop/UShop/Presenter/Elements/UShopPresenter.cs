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
    public class UShopPresenter
    {
        private UShopModel _model;
        private IUShopView _view;

        public SUPPLIER getUShop()
        {
            return _model.getUShop();
        }

        public UShopPresenter()
            : this(null , new UShopModel())
        { 
        }

        public UShopPresenter(IUShopView view)
            : this(view, new UShopModel())
        {
        }

        public UShopPresenter(IUShopView view, UShopModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadUShop()
        {
            _view.loadUShop(_model.getUShop());
        }

        public void updateUShop(SUPPLIER obj)
        {
            _model.updateUShop(obj);
            _view.loadUShop(_model.getUShop());
        }
    }
}
