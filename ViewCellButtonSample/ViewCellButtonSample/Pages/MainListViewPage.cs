using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.Pages.Base;
using ViewCellButtonSample.Pages.ViewCells;
using ViewCellButtonSample.ViewModels;
using Xamarin.Forms;

namespace ViewCellButtonSample.Pages
{
    public class MainListViewPage : BaseContentPage<MainListViewViewModel>
    {

        ListView _underlyingDataListPage;


        public MainListViewPage()
        {
            _underlyingDataListPage = new ListView();

            _underlyingDataListPage.ItemTemplate = new DataTemplate(() => {
                return new SpecificViewCell(this);
            });

            _underlyingDataListPage.SetBinding(ListView.ItemsSourceProperty, nameof(MyViewModel.ObservableCollectionOfUnderlyingData));

            _underlyingDataListPage.HasUnevenRows = true;

            var list = new List<UnderlyingData> { };
            //list = App.PrayerSQLDatabase.GetAllDogs();
            list = App.ListOfUnderlyingData;

            AbsoluteLayout simpleLayout = new AbsoluteLayout
            {
                //#TODO - BACKGROUND
                //BackgroundColor = Color.Blue.WithLuminosity(0.9),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            simpleLayout.Children.Add(_underlyingDataListPage);

            Content = simpleLayout;

        }
    }
}

