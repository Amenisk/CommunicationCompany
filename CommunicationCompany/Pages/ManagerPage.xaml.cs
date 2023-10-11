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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
            cmbTariffs.ItemsSource = App.Connection.Tariff.ToList();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CreateRequest(object sender, RoutedEventArgs e)
        {

        }
    }
}
