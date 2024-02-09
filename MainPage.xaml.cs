using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Launcher1
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnHomeButtonClick(object sender, RoutedEventArgs e)
        {
            // Implementacja obsługi przycisku "Home"
        }

        private void OnChangelogsButtonClick(object sender, RoutedEventArgs e)
        {
            // Implementacja obsługi przycisku "Changelogs"
            MainFrame.Navigate(typeof(changelogs));
        }

        private void OnSettingsButtonClick(object sender, RoutedEventArgs e)
        {
            // Implementacja obsługi przycisku "Settings"
            MainFrame.Navigate(typeof(SettingsPage));
        }

        private void OnOptymalizacjaBasicButtonClick(object sender, RoutedEventArgs e)
        {
            // Implementacja obsługi przycisku "OptymalizacjaBasic"
            MainFrame.Navigate(typeof(OptymalizacjaBasicPage));
        }
    }
}
