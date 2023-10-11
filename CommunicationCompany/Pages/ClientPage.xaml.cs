using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunicationCompany.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GoToOrderPage(object sender, MouseButtonEventArgs e)
        {

        }

        private void DeleteTariff(object sender, RoutedEventArgs e)
        {

        }
    }
}
