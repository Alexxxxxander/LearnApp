using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LearnApp.UI
{
    public class Manager
    {
        public static Frame MainFrame { get;set; }

        public static void ShowMessage()
        {
            MessageBox.Show("В разработке");
        }
    }
}
