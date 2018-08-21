using Prism;
using Prism.Ioc;
using LocalNews.ViewModels;
using LocalNews.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LocalNews
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(new System.Uri("/MainMasterDetailPage/NavigationPage/LocalNewsContentPage", System.UriKind.Absolute));

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(Realms.Realm.GetInstance());
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LocalNewsTabbedPage>();
            containerRegistry.RegisterForNavigation<MainMasterDetailPage>();
            containerRegistry.RegisterForNavigation<LocalNewsContentPage>();
            containerRegistry.RegisterForNavigation<FavoriteContentPage>();
            containerRegistry.RegisterForNavigation<CountryContentPage>();
            containerRegistry.RegisterForNavigation<SourcesContentPage>();
            containerRegistry.RegisterForNavigation<SourcesTabbedPage>();
            containerRegistry.RegisterSingleton<Services.IDataService, Services.DataService>();

            //containerRegistry.RegisterSingleton<Services.DbRealmServices);

            containerRegistry.RegisterForNavigation<LanguageContentPage>();
            containerRegistry.RegisterForNavigation<TopHeadlinesContentPage>();
            containerRegistry.RegisterForNavigation<EverythingContentPage>();
            containerRegistry.RegisterForNavigation<CustomTabbedPage>();
            containerRegistry.RegisterForNavigation<CategoryContentPage>();
            containerRegistry.RegisterForNavigation<CustomWebViewContentPage>();



            containerRegistry.RegisterForNavigation<RecentContentPage>();
        }
    }
}
