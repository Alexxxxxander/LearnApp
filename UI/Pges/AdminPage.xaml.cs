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
using LearnApp.DB;

namespace LearnApp.UI.Pges
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            try
            {
                LBoxServices.ItemsSource = LearnDBEntities.GetContext().Services.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к БД");
                throw;
            }
        }

        private void btnMenuServices_Click(object sender, RoutedEventArgs e)
        {
            Manager.ShowMessage();
        }

        private void btnMenuLastServices_Click(object sender, RoutedEventArgs e)
        {
            Manager.ShowMessage();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Service));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Manager.ShowMessage();
        }
    }
}
