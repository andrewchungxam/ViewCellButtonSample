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

        //public ObservableCollection<UnderlyingData> _observableCollectionOfUnderlyingData;
        //public ObservableCollection<UnderlyingData> ObservableCollectionOfUnderlyingData
        //{
        //    get { return _observableCollectionOfUnderlyingData; }
        //    set { SetProperty(ref _observableCollectionOfUnderlyingData, value); }
        //}
        public ResetableObservableCollection<UnderlyingData> MyObservableCollectionOfUnderlyingData { 
            get; 
            set; 
        } = new ResetableObservableCollection<UnderlyingData>();

        public void ResetDataSource()//(UnderlyingData oldData, UnderlyingData new Data)
        {
            //THIS CODE IS DONE FOR YOU BY XAMARIN FORMS
            //var originalItem = ObservableCollectionOfUnderlyingData.FirstOrDefault(i => i.Id == dataToReplace.Id);
            //if (originalItem is null) return;
            //var index = ObservableCollectionOfUnderlyingData.IndexOf(originalItem);
            //ObservableCollectionOfUnderlyingData[index] = dataToReplace;

            MyObservableCollectionOfUnderlyingData.Reset();
        }


        public MainListViewViewModel()
        {

            SpecificViewCell.ParentViewModel = this;

            var list = new List<UnderlyingData> { };
            //list = App.PrayerSQLDatabase.GetAllDogs();
            list = App.ListOfUnderlyingData;


            //if(list.Count()==0)
            //{
            //_observableCollectionOfUnderlyingData = new ObservableCollection<UnderlyingData>();


            foreach (var underlyingData in list)
                MyObservableCollectionOfUnderlyingData.Add(underlyingData);
            //}

        }
    }
}


      