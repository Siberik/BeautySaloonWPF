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
            Random rnd = new Random();
            CaptchaTextBlock.Text = rnd.Next(1000, 9999).ToString();
            CaptchaTextBlock.LayoutTransform = new RotateTransform(rnd.Next(0,90));
            CaptchaTextBlock.FontSize = rnd.Next(14,30);
            CaptchaTextBlock.Width = rnd.Next(50,100);
            CaptchaTextBlock.Height = rnd.Next(40, 100);
           CaptchaTextBlock.Foreground= new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255),
                  (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 233)));
        }


        private void RegistrationButtonClick(object sender, RoutedEventArgs e)
        {
            
                

        if(CaptchaTextBlock.Text== WriteCapthaTextBox.Text)
            {
                Users newUser = new Users
                {
                    IdRole = 2,
                    UserLogin = NameTextBox.Text,
                    UserLastName = LastNameTextBox.Text,
                    UserOtherName = OtherNamaTextBox.Text,
                    UserName = LoginTextBox.Text,
                    UserPassword = PasswordPasswordBox.Password,
                    
                };
            if(UsersController.AddUser(newUser))
            {
            MessageBox.Show("Вы успешно зарегестрировались");
            }
            UsersController.AddUser(newUser);
            }
            else
            {
                MessageBox.Show("Ты ввёл неверную капчу");
            }
        }

        private void CaptchaButtonClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            CaptchaTextBlock.Text = rnd.Next(1000, 9999).ToString();
            
         
            CaptchaTextBlock.LayoutTransform = new RotateTransform(rnd.Next(0, 90));
            CaptchaTextBlock.FontSize = rnd.Next(14, 30);
            CaptchaTextBlock.Width = rnd.Next(50, 100);
            CaptchaTextBlock.Height = rnd.Next(40, 100);
            CaptchaTextBlock.Opacity = rnd.Next(50, 90);
            CaptchaTextBlock.Foreground = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255),
                 (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 233)));
            
            

        }
    }
}
