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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Authorization(object sender, RoutedEventArgs e)
        {
            if(tbLogin != null && pbPassword != null) 
            {
                var account = App.Connection.Account.FirstOrDefault(x => x.Login == tbLogin.Text && x.Password == pbPassword.Password);

                if(account != null)
                {
                    var user = App.Connection.User.FirstOrDefault(x => x.UserId == account.UserId);

                    switch (user.Role.Title)
                    {
                        case "Client":
                            NavigationService.Navigate(new ClientPage());
                            return;

                        case "Manager":
                            NavigationService.Navigate(new ManagerPage());
                            return;

                        case "Marketer":
                            NavigationService.Navigate(new MarketerPage());
                            return;

                        case "Specialist":
                            NavigationService.Navigate(new SpecialistPage());
                            return;
                    }

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
