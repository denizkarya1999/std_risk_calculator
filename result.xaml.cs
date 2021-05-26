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

namespace std_calculator_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class result : Page
    {
        public static List<string> possible_std = new List<string>();
        public static List<string> likely_std = new List<string>();
        public static List<string> no_std = new List<string>();
        public result()
        {
            this.InitializeComponent();
            foreach (string std in possible_std)
            {
                possible_stds_listbox.Items.Add(std);
            }
            foreach (string std in likely_std)
            {
                likely_stds.Items.Add(std);
            }
            foreach (string std in no_std)
            {
                no_stds.Items.Add(std);
            }
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            possible_std.Clear();
            likely_std.Clear();
            no_std.Clear();
            possible_stds_listbox.Items.Clear();
            likely_stds.Items.Clear();
            no_stds.Items.Clear();
            this.Frame.Navigate(typeof(MainPage));
        }

        private void possible_stds_listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
