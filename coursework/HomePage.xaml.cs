using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfAibrahimW1680174
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ContactsPressed(object sender, RoutedEventArgs e)
        {
            Uri TakeToHome = new Uri("Contacts.xaml", UriKind.Relative);
            this.NavigationService.Navigate(TakeToHome);

        }

        private void ExpensesPressed(object sender, RoutedEventArgs e)
        {
            Uri TakeToHome = new Uri("Expenses.xaml", UriKind.Relative);
            this.NavigationService.Navigate(TakeToHome);

        }

        private void ReportPressed(object sender, RoutedEventArgs e)
        {
            Uri TakeToHome = new Uri("Financial.xaml", UriKind.Relative);
            this.NavigationService.Navigate(TakeToHome);

        }

        private void PredictionPressed(object sender, RoutedEventArgs e)
        {

        }

        private void LogOutPressed(object sender, RoutedEventArgs e)
        {
            // Have an warning box appear to confirm log out and if yes is clicked, quit application
            System.Windows.Application.Current.Shutdown();
        }
    }
}
