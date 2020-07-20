
using MSNews.Views.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSNews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        public static void RegisterRoutes()
        {
            Routing.RegisterRoute("webpage", typeof(WebPage));
        }
    }
}