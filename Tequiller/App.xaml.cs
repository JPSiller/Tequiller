using Prism;
using Prism.Ioc;
using Prism.Unity;
using Tequiller.Views;

namespace Tequiller
{
    public partial class App : PrismApplication
    {
        #region Page Titles
        public const string Main = "MainPage";
        #endregion Page Titles

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(Main);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
