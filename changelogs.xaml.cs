using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Launcher1
{
    public sealed partial class changelogs : Page
    {
        public changelogs()
        {
            this.InitializeComponent();
        }

        private void OnHomeButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Navigate back to Home page
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage));
        }

        private void OnChangelogsButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Obs�uga klikni�cia przycisku "Changelogs"
            // Tutaj mo�esz umie�ci� kod nawigacji lub inny kod obs�ugi zdarzenia
        }

        private void OnSettingsButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Obs�uga klikni�cia przycisku "Settings"
            // Nawiguj do zak�adki "Settings" i przeka� bie��cy stan nawigacji
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(SettingsPage), rootFrame.BackStack);
        }

        private void OnOptymalizacjaBasicButtonClick(object sender, RoutedEventArgs e)
        {
            // Handle the "OptymalizacjaBasic" button click
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(OptymalizacjaBasicPage));
        }
    }
}
