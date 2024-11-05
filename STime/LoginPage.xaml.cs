using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace STime
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Event handler voor de minimaliseerknop
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Event handler voor de maximaliseer/herstelknop
        private void MaximizeRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove(); // Hiermee kun je het venster slepen
            }
        }

        // Event handler voor de sluitknop
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Event handler voor de "Account aanmaken" knop
        private void AccountAanmakenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Account aanmaken klik!", "Account Aanmaken");
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Close();
        }

        // Event handler voor de "Login" knop
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Hier kun je de login-logica toevoegen om gebruikersgegevens te verifiëren.
            // Voor nu, als de knop wordt ingedrukt, open dan de MainWindow.

            // Hier kun je een controle toevoegen om te verifiëren of de gebruiker correct is ingelogd.
            // Dit is een voorbeeld, je kunt hier je eigen logica toevoegen.
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                // Open de MainWindow
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Sluit de huidige LoginPage
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul a.u.b. uw gebruikersnaam en wachtwoord in.", "Inloggen Fout");
            }
        }



        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Gebruikersnaam")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Gebruikersnaam";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void PasswordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordPlaceholder.Visibility = passwordBox.Password.Length > 0 ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
