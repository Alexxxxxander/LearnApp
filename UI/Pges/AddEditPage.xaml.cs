using LearnApp.DB;
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

namespace LearnApp.UI.Pges
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Service _currentService = new Service();
        public AddEditPage(Service currentService)
        {
            InitializeComponent();
            try
            {
                DataContext = LearnDBEntities.GetContext().Services;
            }
            catch (Exception)
            {

                throw;
            }
            if (currentService != null)
            {
                _currentService = currentService; 
            }
            DataContext = _currentService;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentService.Title))
                errors.AppendLine("Укажите название отеля");
            if (_currentService.Cost<=0)
                errors.AppendLine("Цена - число больше 0");
            if (_currentService.DurationInMinutes <= 0 || _currentService.DurationInMinutes >240)
                errors.AppendLine("Длительность в минутах - число больше 0 и меньше 240");
            if (_currentService.Discount>100 || _currentService.Discount<0)
                errors.AppendLine("Скидка - число от 1 до 100");
            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_currentService.ID == 0)
            {
                LearnDBEntities.GetContext().Services.Add(_currentService);
            }
            try
            {
                LearnDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.Navigate(new AdminPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdminPage());
        }
    }
}
