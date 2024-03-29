﻿using Prism;
using Prism.Ioc;
using save_state.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using save_state.Services;
using Prism.Unity;
using save_state.ViewModels;
using System.Threading.Tasks;

namespace save_state
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            // Task.Run(() => { NavigationService.NavigateAsync("ListPage"); });
            await NavigationService.NavigateAsync("RootPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MenuPage>();
            containerRegistry.RegisterForNavigation<RootPage>();
            containerRegistry.RegisterForNavigation<CalendarPage>();
            containerRegistry.RegisterForNavigation<RegisterPage>();
            containerRegistry.RegisterForNavigation<ListPage>();
            containerRegistry.RegisterForNavigation<AnalysisPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }
    }
}
