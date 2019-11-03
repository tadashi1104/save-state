using System;
using System.Collections.Generic;
using System.Linq;
using PublicHoliday;
using Xamarin.Forms;
using XamForms.Controls;

namespace save_state.Views
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();

            _calendar.OnEndRenderCalendar += (sender, e) =>
            {
                (_calendar.Content as StackLayout).Children.Last().HeightRequest = 180;
            };

            // SetWeekend(2019);
            // SetHoliday(2019);

        }

        /// <summary>
        /// 祝日の色設定
        /// </summary>
        /// <param name="year">対象年</param>
        private void SetHoliday(int year)
        {
            IList<DateTime> result = new JapanPublicHoliday().PublicHolidays(year);

            foreach (var holiday in result)
            {
                _calendar.SpecialDates.Add(new SpecialDate(holiday)
                {
                    TextColor = Color.Red
                });
            }
        }

        /// <summary>
        /// 土日の色設定
        /// </summary>
        /// <param name="year">対象年</param>
        private void SetWeekend(int year)
        {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            /* 元旦から大晦日まで1日ずつ曜日確認 */
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                if (DayOfWeek.Saturday == day.DayOfWeek)
                {
                    _calendar.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Blue
                    });
                }
                else if (DayOfWeek.Sunday == day.DayOfWeek)
                {
                    _calendar.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Red
                    });
                }
            }
        }

        protected void OnDateClickHandler(object sender, EventArgs e)
        {

            _listHeader.Text = _calendar.SelectedDate?.ToString("yyyy/MM/dd (ddd)");
        }
    }
}
