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

namespace Escape_Quiz.Views
{
    /// <summary>
    /// Interaction logic for EndView.xaml
    /// </summary>
    public partial class EndView : UserControl
    {
        private Frame frame;
        public EndView(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
            Random rnd = new Random();
            // 'ア', 'ン'
            char randomChar = (char)rnd.Next('c', 'z');
            for (int i = 0; i == 5; i++)
            {
                L1.Content = randomChar;
            }
            //'a' and 'z' are interpreted as ints for parameters for Next()
        }

        public void CodeGeneration()
        {
            Random rnd = new Random();
            // 'ア', 'ン'
            char randomChar = (char)rnd.Next('c', 'z');
            for(int i = 0; i == 5; i++)
            {
                L1.Content = randomChar;
            }
            //'a' and 'z' are interpreted as ints for parameters for Next()
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
