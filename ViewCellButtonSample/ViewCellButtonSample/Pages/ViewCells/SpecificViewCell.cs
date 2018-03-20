using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
//using ViewCellButtonSample.Helpers;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.ViewModels;
using Xamarin.Forms;

namespace ViewCellButtonSample.Pages.ViewCells
{
    public class SpecificViewCell : ViewCell
    {
        public static MainListViewViewModel ParentViewModel;

        Label testNumber;

        //public SpecificViewCell(MainListViewPage underlyingMainListViewPage)
        public SpecificViewCell()
        {
            //var model = BindingContext as UnderlyingData;
            //
            //TEST-BUTTON
            var testButton = new Button()
            {
                Text = "Test +"
            };

            testNumber = new Label() { };

            //TEST-BUTTON
            testButton.SetBinding(Button.CommandParameterProperty, new Binding("."));
            //            testButton.SetBinding(Button.CommandProperty, new Binding("BindingContext.TestButtonClickCommand", source: underlyingMainListViewPage));
            testButton.SetBinding(Button.CommandProperty, new Binding("BindingContext.TestButtonClickCommand", source: (MainListViewViewModel)ParentViewModel));
            testNumber.SetBinding(Label.TextProperty, nameof(UnderlyingData.TheChangingString), BindingMode.Default);

            //testNumber.SetBinding(Label.TextProperty, nameof(UnderlyingData.TheChangingString), BindingMode.OneWay);

            testButton.Clicked += (sender, e) =>
            {
                var button = (Button)sender;
                //var prayerRequest = (ViewCellButtonSample.Models.UnderlyingData)button.CommandParameter;

                string newString = "2nd string";

                //ID OF THE DATA IN THE CELL
                var cellBindingContext = (ViewCellButtonSample.Models.UnderlyingData)this.BindingContext;
                if (cellBindingContext != null)
                {
                    cellBindingContext.TheChangingString = "new and updated";
                    //ParentViewModel.ReplaceDataItem(cellBindingContext);
                    ParentViewModel.ResetDataSource();
                }







                //int cellUnderlyingDataId = cellBindingContext.Id;

                //var testCollectionOfPrayers = underlyingMainListViewPage.MyViewModel.ObservableCollectionOfUnderlyingData;

                //ObservableCollection<ViewCellButtonSample.Models.UnderlyingData> tempObservableCollection = underlyingMainListViewPage.MyViewModel.ObservableCollectionOfUnderlyingData; //.Where(x.Id == cellPrayerRequestId);
                //var specificUnderlyingData = tempObservableCollection.FirstOrDefault(x => x.Id == cellUnderlyingDataId);
                //if (specificUnderlyingData != null)
                //{
                //    specificUnderlyingData.TheChangingString = "new and updated";
                //}

                //underlyingMainListViewPage.MyViewModel.ObservableCollectionOfUnderlyingData = tempObservableCollection;

                ////DONT NEED THE BELOW - BUT LEAVING IT FOR GOOD MEASURE
                //underlyingMainListViewPage.MyViewModel._observableCollectionOfUnderlyingData = tempObservableCollection;
            };


            #region GRID DEFINITION
            var grid = new Grid()
            {
                Padding = new Thickness(10, 10, 10, 10)
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
 
            //TEST-ROW
            grid.Children.Add(testButton, 0, 0);
            Grid.SetColumnSpan(testButton, 1);

            grid.Children.Add(testNumber, 1, 0);
            Grid.SetColumnSpan(testNumber, 1);

            View = grid;
            #endregion

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as UnderlyingData;
            if (item is null) return;

            testNumber.Text = item?.TheChangingString ?? "Some Error Happened";
        }
    }
}



