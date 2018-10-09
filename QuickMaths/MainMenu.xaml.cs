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

namespace QuickMaths
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Year7_Click(object sender, RoutedEventArgs e)
        {
            TopicPage topic_page = new TopicPage(7);
            NavigationService.Navigate(topic_page);
        }

        private void Button_Year8_Click(object sender, RoutedEventArgs e)
        {
            TopicPage topic_page = new TopicPage(8);
            NavigationService.Navigate(topic_page);
        }

        private void Button_Year9_Click(object sender, RoutedEventArgs e)
        {
            TopicPage topic_page = new TopicPage(9);
            NavigationService.Navigate(topic_page);
        }

        private void Button_Year10_Click(object sender, RoutedEventArgs e)
        {
            TopicPage topic_page = new TopicPage(10);
            NavigationService.Navigate(topic_page);
        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
