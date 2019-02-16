using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCommonControlsPart1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Commoncontrolspart2 : Page
    {
        public Commoncontrolspart2()
        {
            this.InitializeComponent();
        }

        private void CalendarView_OnSelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selecteddates = sender.SelectedDates
                .Select(p => p.Date.Month.ToString() + " / " + p.Date.Day.ToString()).ToArray();
            var values = string.Join(" , ", selecteddates);
            CalenderViewTextBlock.Text = values;
        }

        private void MyInnerFlyoutButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
           // throw new NotImplementedException();
        }

        private List<string> Names = new List<string>()
        {
            "Humphry", "Alfred", "Alex", "Allan", "Brednda", "Carson", "Frankline", "Randy"
        };

        private void AutoSuggestBox_OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autosuggestionbox = (AutoSuggestBox)sender;
            var filtered = Names.Where(p => p.StartsWith(autosuggestionbox.Text)).ToArray();
            autosuggestionbox.ItemsSource = filtered;

        }
    }
}
