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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = ServiceCategoryesController.GetServiceCategoryes();
        }
       
        /// <summary>
        /// Выбор категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //определяем по кому кликнули
            Grid categoryButton = sender as Grid;
            //определяем строку из таблицы ServiceCategoryes, связанную с выбранным элементом
            ServiceCategoryes activeServiceCategory =categoryButton.DataContext as ServiceCategoryes;
          
            this.NavigationService.Navigate(new CategoryPage(activeServiceCategory));
        }

        private void LogOutButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthorizationPage());
        }
    }

   
    }
