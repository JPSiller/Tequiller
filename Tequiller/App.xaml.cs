using Prism;
using Prism.Ioc;
using Prism.Unity;
using Tequiller.Views;

namespace Tequiller
{
    public partial class App : PrismApplication
    {
        #region Page Titles
        public const string TabbedContent = "TabbedContentPage";
        public const string Main = "MainPage";
        public const string Search = "SearchPage";
        public const string Favorites = "FavoritesPage";
        public const string Settings = "SettingsPage";
        #endregion Page Titles

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(TabbedContent);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TabbedContentPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<SearchPage>();
            containerRegistry.RegisterForNavigation<FavoritesPage>();
            containerRegistry.RegisterForNavigation<SettingsPage>();
        }
    }
}
