using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace save_state.ViewModels
{
    public class RootPageViewModel : BindableBase
    {
        public RootPageViewModel()
        {
        }

        public ObservableCollection<MenuItem> Menus { get; } = new ObservableCollection<MenuItem>
        {
            new MenuItem
            {
                Title = "Calendar",
                PageName = "CalendarPage"
            },
            new MenuItem
            {
                Title = "List",
                PageName = "ListPage"
            },
            new MenuItem
            {
                Title = "Analysis",
                PageName = "AnalysisPage"
            },
            new MenuItem
            {
                Title = "Register",
                PageName = "RegisterPage"
            },
        };

        private INavigationService NavigationService { get; }

        private bool isPresented;

        public bool IsPresented
        {
            get { return this.isPresented; }
            set { this.SetProperty(ref this.isPresented, value); }
        }

        public RootPageViewModel(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        public async Task PageChangeAsync(MenuItem menuItem)
        {
            await this.NavigationService.NavigateAsync($"RootPage/NavigationPage/MainPage/{menuItem.PageName}");
            this.IsPresented = false;
        }
    }
}
