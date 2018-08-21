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
	public class CategoryContentPageViewModel : ViewModelBase
	{

        private readonly INavigationService _navigationService;
        public CategoryContentPageViewModel(INavigationService navigationService) :
        base(navigationService)
        {

            _navigationService = navigationService;
            Title = "Category";
            IsRunning = true;
            _categoryList = GetCategory();
            ExecuteCommand = new DelegateCommand(ExecuteNavigation);
            IsRunning = false;

        }

        public ICommand ExecuteCommand
        {
            get;
        }


        private List<Category> _categoryList = new List<Category>();
        public List<Category> CategoryList
        {
            get { return _categoryList; }
            set { SetProperty(ref _categoryList, value); }
        }
        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => SetProperty(ref _selectedCategory, value);
        }


        async void ExecuteNavigation()
        {
            var navigationParams = new NavigationParameters
            {
                {
                    "model", _selectedCategory
                }
            }; 
            StaticObject.MasterSelected = eMasterSelected.Category;

            navigationParams.Add("Name", _selectedCategory.Name);
            await _navigationService.NavigateAsync("SourcesContentPage", navigationParams);
        }
        public List<Category> GetCategory()
        {
            List<Category> category = new List<Category>();
            category.Add(new Category() { Id = "business", Name = eCategory.Business });
            category.Add(new Category() { Id = "entertainment", Name = eCategory.Entertainment});
            category.Add(new Category() { Id = "general", Name = eCategory.General });
            category.Add(new Category() { Id = "health", Name = eCategory.Health });
            category.Add(new Category() { Id = "science", Name = eCategory.Science });
            category.Add(new Category() { Id = "sports", Name = eCategory.Sports });
            category.Add(new Category() { Id = "technology", Name =eCategory.Technology});
            category.Add(new Category() { Id = "all", Name = eCategory.All });

            return category;
        }

    }
}
