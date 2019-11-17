using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace save_state.ViewModels
{
    public class MainPageViewModel : BindableBase
    {

        private INavigationService NavigationService { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }
    }
}
