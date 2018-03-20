using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.Pages.ViewCells;
using ViewCellButtonSample.ViewModels.Base;

namespace ViewCellButtonSample.ViewModels
{
    public class ResetableObservableCollection<T> : ObservableCollection<T>
    {
        public void Reset() => this.OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
    }


    public class MainListViewViewModel: BaseViewModel
    {
        string _theChangingString;
        public string TheChangingString
        {
            get { return TheChangingString; }
            set { SetProperty(ref _theChangingString, value); }
        }

        public ResetableObservableCollection<UnderlyingData> MyObservableCollectionOfUnderlyingData { 
            get; 
            set; 
        } = new ResetableObservableCollection<UnderlyingData>();

        public void ResetDataSource()//(UnderlyingData oldData, UnderlyingData new Data)
        {
          
            MyObservableCollectionOfUnderlyingData.Reset();
        }


        public MainListViewViewModel()
        {

            SpecificViewCell.ParentViewModel = this;

            var list = new List<UnderlyingData> { };
            list = App.ListOfUnderlyingData;

            foreach (var underlyingData in list)
                MyObservableCollectionOfUnderlyingData.Add(underlyingData);
            //}

        }
    }
}


      