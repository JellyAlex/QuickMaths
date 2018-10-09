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
    /// Interaction logic for TopicPage.xaml
    /// </summary>
    public partial class TopicPage : Page
    {
        // A byte is a small unsigned integer that can hold 0 - 255.
        private byte m_Year = 0;

        public TopicPage()
        {
            InitializeComponent();

            // Year defaults to 7 if none is specified.
            m_Year = 7;


        }

        public TopicPage(byte year)
        {
            InitializeComponent();

            m_Year = year;

            if (m_Year < 7 || m_Year > 10)
            {
                Console.WriteLine("Error: Invalid year specified: " + year);
                // Year defaults to 7 if none is specified.
                m_Year = 7;
            }

            Console.WriteLine("Year specified: " + m_Year);

        }

        private void TopicPage_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
