using Xamarin.Forms;

namespace MSNews.Views.Components.NewComponents
{
    public class NewsComponentsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NewsView { get; set; }
        public DataTemplate WideNewsView { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (((Models.Article)item).IsWideView)
                return WideNewsView;
            return NewsView;
        }
    }
}
