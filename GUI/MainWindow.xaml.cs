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
using MahApps.Metro.Controls;
using CustomUserControl;

namespace GUI
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void show_info_page(object sender, RoutedEventArgs e)
        {
            InfoPage info_page = this.MainGrid.FindName("UCInformation") as InfoPage;

            //show info page, hide the rest
            info_page.Visibility = Visibility.Visible;
        }

        private void show_prod_page(object sender, RoutedEventArgs e)
        {
            InfoPage info_page = this.MainGrid.FindName("UCInformation") as InfoPage;

            //show info page, hide the rest
            info_page.Visibility = Visibility.Collapsed;
        }

        private void show_assistant_page(object sender, RoutedEventArgs e)
        {

        }

        private void show_parameter_page(object sender, RoutedEventArgs e)
        {

        }
    }
}