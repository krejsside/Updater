using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Launcher1
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void OnHomeButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Navigate back to Home page
            MainFrame.Navigate(typeof(MainPage));
        }

        private void OnChangelogsButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Handle Changelogs button click
            // You can add your own code here
            MainFrame.Navigate(typeof(changelogs));
        }

        private void OnSettingsButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Handle Settings button click
            // You can add your own code here
        }

        private void OnOptymalizacjaBasicButtonClick(object sender, RoutedEventArgs e)
        {
            // Handle the "OptymalizacjaBasic" button click
            MainFrame.Navigate(typeof(OptymalizacjaBasicPage));
        }

    }
}
