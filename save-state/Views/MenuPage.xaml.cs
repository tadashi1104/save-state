using System;
using System.Collections.Generic;
using save_state.ViewModels;
using Xamarin.Forms;

namespace save_state.Views
{
    public partial class MenuPage : ContentPage
    {
        private RootPageViewModel ViewModel => this.BindingContext as RootPageViewModel;

        public MenuPage()
        {
            InitializeComponent();
        }

        private async void ListViewMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await this.ViewModel.PageChangeAsync(e.SelectedItem as ViewModels.MenuItem);
        }
    }
}
