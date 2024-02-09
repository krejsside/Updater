using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Launcher1
{
    public sealed partial class OptymalizacjaBasicPage : Page
    {
        public OptymalizacjaBasicPage()
        {
            this.InitializeComponent();
        }

        private void OnHomeButtonClick(object sender, RoutedEventArgs e)
        {
            // Navigate back to Home page
            MainFrame.Navigate(typeof(MainPage));
        }

        private void OnOptymalizacjaBasicButtonClick(object sender, RoutedEventArgs e)
        {
            // Handle the "OptymalizacjaBasic" button click
            // This method is called when the "OptymalizacjaBasic" button is clicked
        }

        private void OnChangelogsButtonClick(object sender, RoutedEventArgs e)
        {
            // Navigate to Changelogs page
            MainFrame.Navigate(typeof(changelogs));
        }

        private void OnSettingsButtonClick(object sender, RoutedEventArgs e)
        {
            // Navigate to Settings page
            MainFrame.Navigate(typeof(SettingsPage));
        }
    }
}
