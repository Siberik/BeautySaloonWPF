using BeautySaloonWPF.Controllers;
using BeautySaloonWPF.Models;
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

namespace BeautySaloonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButtonClick(object sender, RoutedEventArgs e)
        {
            
                Users user = new Users
                {
                    IdRole = 1,
                    UserLogin = "Володя",
                    UserLastName = "s",
                    UserOtherName = "Абобович",
                    UserName = "biba",
                    UserPassword = "assaas1",
                    IdroleNavigation=
                };
            
            
            UsersController.AddUser(user);
        }
    }
}
