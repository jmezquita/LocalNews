using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LocalNews.ViewModels
{
    public class LocalNewsTabbedPageViewModel : ViewModelBase
    {

        //private readonly IBeersService _beersService;
        private readonly INavigationService _navigationService;
        public LocalNewsTabbedPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            //_beersService = beersService;
            _navigationService = navigationService;
            Title = "Local News";
            IsRunning = true;
            //BeersList = new ObservableCollection<Beers>();
            //_OriginalBeersList = new ObservableCollection<Beers>();
            SearchButtonCommand = new DelegateCommand(ExecuteClick, CanExecuteClick);
            //ExecuteDetailsCommand = new DelegateCommand(ExecuteDetails);

            ////NavigateCommand = new DelegateCommand(Navigate);


            GetLocalNewsFromAPI();
        }

        private void ExecuteClick()
        {
            IsVisibleSearch = !IsVisibleSearch;

            if (IsVisibleSearch)
            {

                //Entry myEntry = t.FindByName<Entry>("YourEntryName");
                //myEntry.Focus();
            }

        }

        private bool CanExecuteClick()
        {
            return IsNotRunning;
        }
        private bool _isVisibleSearch = false;
        public bool IsVisibleSearch
        {
            get { return _isVisibleSearch; }
            set
            {
                SetProperty(ref _isVisibleSearch, value);
                if (!value)
                {
                    SearchEntryText = "";

                    //BeersList = new ObservableCollection<Beers>(from beer in _OriginalbeersList
                    //                                            select beer);
                }

            }
        }
        private string _SearchEntryText; 
        public string SearchEntryText
        {
            get { return _SearchEntryText; }
            set
            {
                SetProperty(ref _SearchEntryText, value);
                //BeersList = new ObservableCollection<Beers>(from beer in _OriginalBeersList
                //                                            where string.IsNullOrEmpty(_entryText) ||
                //                                            beer.Name.IndexOf(_entryText, StringComparison.OrdinalIgnoreCase) > -1
                //                                            select beer);
            }
        }

        public ICommand SearchButtonCommand
        {
            get;
        }

        async void GetLocalNewsFromAPI()
        {
        //    IsRunning = true;
        //    var result = await _beersService.GetAllBeersAsync();
        //    IsRunning = false;
        //    foreach (var item in result)
        //    {
        //        BeersList.Add(item);
        //        _OriginalBeersList.Add(item);
        //    }

         ((DelegateCommand)SearchButtonCommand).RaiseCanExecuteChanged();
        }

    }

}

