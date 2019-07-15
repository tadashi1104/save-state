﻿using System;
using save_state.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace save_state
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegisterView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
