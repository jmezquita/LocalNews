using LocalNews.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalNews.ViewModels
{
	public class SourcesTabbedPageViewModel : ViewModelBase
	{
        public SourcesTabbedPageViewModel(INavigationService navigationService) :
      base(navigationService)
        {
            //LabelInformation = "Loading Dada...";
            Title = "All Sources";
            
            //_source = new Source();
        }

        private Source _source;
        public Source Source
        {
            get { return _source; }
            set { SetProperty(ref _source, value); }
        }
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            //StaticObject.MasterSelected = eMasterSelected.Source;
            //Source = (Source)parameters["model"];
            //Title = Source.Name;
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
