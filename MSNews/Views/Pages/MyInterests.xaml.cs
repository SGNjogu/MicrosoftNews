﻿using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSNews.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyInterests : ContentPage
    {
        public MyInterests()
        {
            InitializeComponent();
            BindingContext = ViewModels.InterestsViewModel.Instance;
        }

        private async void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionView.SelectedItem != null)
            {
                var selected = e.CurrentSelection.FirstOrDefault() as Models.Interest;

                ViewModels.InterestsViewModel.Instance.CurrentInterest = selected;
                ViewModels.InterestsViewModel.Instance.CurrentItem = new Models.Tab { Title = selected.Title };

                await Shell.Current.GoToAsync($"interestarticles");

                collectionView.SelectedItem = null;
            }
        }
    }
}