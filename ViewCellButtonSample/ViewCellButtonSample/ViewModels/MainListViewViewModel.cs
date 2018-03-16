using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.ViewModels.Base;

namespace ViewCellButtonSample.ViewModels
{
    public class MainListViewViewModel: BaseViewModel
    {

        string _theChangingString;
        public string TheChangingString
        {
            get { return TheChangingString; }
            set { SetProperty(ref _theChangingString, value); }
        }

        public ObservableCollection<UnderlyingData> _observableCollectionOfUnderlyingData;
        public ObservableCollection<UnderlyingData> ObservableCollectionOfUnderlyingData
        {
            get { return _observableCollectionOfUnderlyingData; }
            set { SetProperty(ref _observableCollectionOfUnderlyingData, value); }
        }

        public MainListViewViewModel()
        {



            var list = new List<UnderlyingData> { };
            //list = App.PrayerSQLDatabase.GetAllDogs();
            list = App.ListOfUnderlyingData;


            //if(list.Count()==0)
            //{
            _observableCollectionOfUnderlyingData = new ObservableCollection<UnderlyingData>();
            foreach (var underlyingData in list)
                _observableCollectionOfUnderlyingData.Add(underlyingData);
            //}

        }
    }
}


      