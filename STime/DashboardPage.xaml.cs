using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace STime
{
    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        // Event handler for adding a horse
        private void HorseCard_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Open een nieuw venster of dialoog met paardeninformatie
            MessageBox.Show("Paardeninformatie venster openen!");
            // Hier kun je code toevoegen om een venster met uitgebreide info te openen
        }
    }
}
