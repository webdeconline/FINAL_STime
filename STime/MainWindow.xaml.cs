using System.Windows;

namespace STime
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Startpagina instellen
            MainFrame.Content = new DashboardPage();
        }

        private void GoToDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DashboardPage();
        }

        private void GoToDayJob_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DayJobPage();
        }

        private void GoToPaymentInfo_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaymentInfoPage();
        }

        private void GoToAddHorse_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AddHorsePage();
        }

        private void GoToStal_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new StalPage();
        }
    }
}
