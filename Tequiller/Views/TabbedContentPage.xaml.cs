using Xamarin.Forms;
using Prism.Navigation;

namespace Tequiller.Views
{
    public partial class TabbedContentPage : TabbedPage, INavigatingAware
    {
        public TabbedContentPage()
        {
            InitializeComponent();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            foreach (var child in Children)
            {
                (child as INavigatingAware)?.OnNavigatingTo(parameters);
                (child?.BindingContext as INavigatingAware)?.OnNavigatingTo(parameters);
            }
        }
    }
}
