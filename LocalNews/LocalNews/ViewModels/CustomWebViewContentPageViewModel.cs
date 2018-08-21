using LocalNews.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalNews.ViewModels
{
	public class CustomWebViewContentPageViewModel : ViewModelBase
	{
  

        private readonly INavigationService _navigationService;
        //private readonly IDataService _sourcesService;
        public CustomWebViewContentPageViewModel(INavigationService navigationService) :
        base(navigationService)
        {
           // _sourcesService = sourcesService;
            _navigationService = navigationService;

           

        }

        private string _urlPage;

        public string UrlPage
        {
            get { return _urlPage; }
            set { SetProperty(ref _urlPage, value);}
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            UrlPage = (string)parameters["UrlPage"];
            Title = (string)parameters["PageName"];
        }




    }
}
