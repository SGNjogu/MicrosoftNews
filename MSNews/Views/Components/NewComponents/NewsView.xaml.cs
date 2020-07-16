
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSNews.Views.Components.NewComponents
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsView : ViewCell
    {
        public NewsView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            image.Source = null;

            var bindingContext = BindingContext as Models.Article;

            image.Source = bindingContext.UrlToImage;
            description.Text = bindingContext.Description;
            source.Text = $"{bindingContext.Source} . ";
            published.Text = bindingContext.Published;
        }
    }
}