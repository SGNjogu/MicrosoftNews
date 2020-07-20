
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSNews.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterestArticles : ContentPage
    {
        public InterestArticles()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
            BindingContext = ViewModels.InterestsViewModel.Instance;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tapped = e.Item as Models.Article;

            await Navigation.PushAsync(new WebPage(tapped));
        }
    }
}