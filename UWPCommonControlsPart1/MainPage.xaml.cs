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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCommonControlsPart1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CheckBox_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock4.Text = CheckBox.IsChecked.ToString();
        }

        private void RadioButton1_OnChecked(object sender, RoutedEventArgs e)
        {
            TextBlock5.Text =  RadioButton1.IsChecked.ToString();
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox) sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            TextBlock1.Text = item.Content.ToString();
        }

       

        private void ToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBlock6.Text = ToggleButton.IsChecked.ToString();
        }

      /*  private void MyListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditems = MyListBox.Items.Cast<ListBoxItem>()
                .Where(t => t.IsSelected).Select(p => p.Content.ToString()).ToArray();
            TextBlock3.Text = String.Join(" , ", selecteditems.ToString());

            
        }*/
      private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
      {
          Frame.Navigate(typeof(Commoncontrolspart2));
      }
    }
}
