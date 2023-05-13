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
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>
    public partial class LogPage : Page
    {
        public LogPage()
        {
            InitializeComponent();
        }


        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxPassword.Text == "0000")
            {
                Manager.MainFrame.Navigate(new AdminPage());
            }
        }

        private void BtnSkip_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new DefaultPage());
        }
    }
}
