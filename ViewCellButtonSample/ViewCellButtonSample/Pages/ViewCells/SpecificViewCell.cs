using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.ViewModels;
using Xamarin.Forms;

namespace ViewCellButtonSample.Pages.ViewCells
{
    public class SpecificViewCell : ViewCell
    {
        public static MainListViewViewModel ParentViewModel;

        Label testNumber;

        public SpecificViewCell()
        {
            //TEST-BUTTON
            var testButton = new Button()
            {
                Text = "Test +"
            };

            testNumber = new Label() { };

            //TEST-BUTTON

            //THIS COMMANDPROPERTIES ARE OPTIONAL - USE THESE IS YOU WANT TO USE THE COMMANDING PATTERN
            testButton.SetBinding(Button.CommandParameterProperty, new Binding("."));
            testButton.SetBinding(Button.CommandProperty, new Binding("BindingContext.TestButtonClickCommand", source: (MainListViewViewModel)ParentViewModel));


            testNumber.SetBinding(Label.TextProperty, nameof(UnderlyingData.TheChangingString), BindingMode.Default);

            testButton.Clicked += (sender, e) =>
            {
                var button = (Button)sender;
                string newString = "2nd string";

                var cellBindingContext = (ViewCellButtonSample.Models.UnderlyingData)this.BindingContext;
                if (cellBindingContext != null)
                {
                    cellBindingContext.TheChangingString = "new and updated";
                    ParentViewModel.ResetDataSource();
                }

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



