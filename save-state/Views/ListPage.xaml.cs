using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace save_state.Views
{
    // ToDo: Modelクラスに移動したりViewModelで実施したりあとで色々やる。
    public class ListItem : ObservableCollection<DateInfo>
    {
        public string Month { get; set; }

        public ListItem(string month)
        {
            this.Month = month;
        }
    }

    public class DateInfo
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Overview { get; set; }
        public string DateTime { get => $"{Date}日 {Time}"; }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ObservableCollection<ListItem> ViewItems { get; set; }

        public ListPage()
        {
            InitializeComponent();

            ViewItems = new ObservableCollection<ListItem>
            {
                new ListItem("6月") {
                     new DateInfo {
                         Date = "25",
                         Time = "10:32",
                         Overview = "今日はいい感じ。"
                     },
                     new DateInfo {
                         Date = "25",
                         Time = "17:56",
                         Overview = "今日はやっぱりダメだった。"
                     },
                     new DateInfo {
                         Date = "28",
                         Time = "12:40",
                         Overview = "今日はいい感じのはず。"
                     }
                 },
                new ListItem("7月") {
                     new DateInfo {
                         Date = "01",
                         Time = "22:55",
                         Overview = "今日は疲れた。"
                     },
                     new DateInfo {
                         Date = "03",
                         Time = "09:56",
                         Overview = "今日はいい朝。"
                     }
                 }
            };

            _stateList.ItemsSource = ViewItems;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
