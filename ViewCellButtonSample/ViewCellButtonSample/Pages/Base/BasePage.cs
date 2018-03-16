using System;

using Xamarin.Forms;
using ViewCellButtonSample.ViewModels.Base;

namespace ViewCellButtonSample.Pages.Base
{
    public abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {

        T _viewModel;

        public BaseContentPage()
        {
            BindingContext = MyViewModel;
        }

        public T MyViewModel
        {
            get
            {
                return _viewModel ?? (_viewModel = new T());
            }
        }
    }
}

