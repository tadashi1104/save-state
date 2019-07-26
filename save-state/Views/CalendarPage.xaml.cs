using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace save_state.Views
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
        }

        protected void OnDateClickHandler(object sender, EventArgs e)
        {

            _listHeader.Text = _calendar.SelectedDate?.ToString("yyyy/MM/dd (ddd)");
        }
    }
}
