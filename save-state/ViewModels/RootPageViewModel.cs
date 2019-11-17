using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace save_state.ViewModels
{
    public class RootPageViewModel : BindableBase, IActiveAware
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

        ICommand MoveCommand { get; }

        public RootPageViewModel(INavigationService navigationService)
        {
            //MoveCommand = new DelegateCommand<MenuItem>(async item =>
            //{
            //    if (item == null)
            //    {
            //        return;
            //    }
            //    await navigationService.NavigateAsync($"{item.PageName}");
            //});
            this.NavigationService = navigationService;
        }

        public ICommand NavigateCommand => new Command<MenuItem>(async item =>
        {
            if (item == null)
            {
                return;
            }
            await MainPageViewModel.NavigationService.NavigateAsync($"NavigationPage/{item.PageName}");
        });

        //public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #region IActiveAware Members

        private bool _isActive;

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    OnActiveChanged(this, EventArgs.Empty);
                }
            }
        }

        private void OnActiveChanged(object sender, EventArgs e)
        {
            IsActiveChanged?.Invoke(sender, e);
        }

        public event EventHandler IsActiveChanged;
        #endregion
    }
}
