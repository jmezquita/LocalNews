using LocalNews.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LocalNews.ViewModels
{
	public class LocalNewsContentPageViewModel : ViewModelBase
    {


        private readonly INavigationService _navigationService;
        public LocalNewsContentPageViewModel(INavigationService navigationService) :
        base(navigationService)
        {
            IsRunning = true;
            _navigationService = navigationService;
            Title = "Local News";
            _localNewsList= GetLocalNews();
            ExecuteCommand = new DelegateCommand(ExecuteNavigation);
            IsRunning = false;

        }

        public ICommand ExecuteCommand
        {
            get;
        }


        private List<LocalNewsModel> _localNewsList = new List<LocalNewsModel>();
        public List<LocalNewsModel> LocalNewsList
        {
            get { return _localNewsList; }
            set { SetProperty(ref _localNewsList, value); }
        }
        private LocalNewsModel _selectedItem;
        public LocalNewsModel SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        async void ExecuteNavigation()
        {
            var navigationParams = new NavigationParameters
            {
                {
                    "model", _selectedItem
                }
            };
            navigationParams.Add("PageName", _selectedItem.Name);
            navigationParams.Add("UrlPage", _selectedItem.Url);
            await _navigationService.NavigateAsync("CustomWebViewContentPage", navigationParams);


        }
        public List<LocalNewsModel> GetLocalNews()
        {
            List<LocalNewsModel> LocalNews = new List<LocalNewsModel>();
           
            LocalNews.Add(new LocalNewsModel() { Name = "Acento", Url = "https://acento.com.do" });
            LocalNews.Add(new LocalNewsModel() { Name = "Remolacha.net",Url= "https://remolacha.net" });
            LocalNews.Add(new LocalNewsModel() { Name = "Diario Libre", Url = "https://www.diariolibre.com" });
            LocalNews.Add(new LocalNewsModel() { Name = "El Dia", Url= "http://eldia.com.do" });
            LocalNews.Add(new LocalNewsModel() { Name= "CDN", Url = "http://www.cdn.com.do" });
            LocalNews.Add(new LocalNewsModel() { Name = "Listin Diario", Url= "https://www.listindiario.com" });
            LocalNews.Add(new LocalNewsModel() { Name = "Hoy", Url = "http://hoy.com.do" });
            LocalNews.Add(new LocalNewsModel() { Name = "El Caribe", Url = "https://www.elcaribe.com.do" });

            return LocalNews;
        }

    }
}
