using System;

using Xamarin.Forms;

namespace save_state.Views
{
    public class AnalysisPage : ContentPage
    {
        public AnalysisPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


