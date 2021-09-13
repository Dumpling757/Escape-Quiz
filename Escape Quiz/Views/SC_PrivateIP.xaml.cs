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
    /// Interaktionslogik für SC_PrivateIP.xaml
    /// </summary>
    public partial class SC_PrivateIP : UserControl
    {
        private Frame frame;
        private int checkI;
        public SC_PrivateIP(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            if (checkI == 0 && (bool)privIP.IsChecked) { MessageBox.Show("Its right!"); }
            else if (checkI == 0) { MessageBox.Show("Leider nicht richtig.\nSchau dir die Lösungen an und gehe dann weiter zur nächsten Aufgabe!"); }

            privIP.Foreground = new SolidColorBrush(Colors.Green);
            privIP.IsEnabled = false;

            localhost.Foreground = new SolidColorBrush(Colors.Red);
            localhost.IsEnabled = false;

            APIPA.Foreground = new SolidColorBrush(Colors.Red);
            APIPA.IsEnabled = false;

            pubIP.Foreground = new SolidColorBrush(Colors.Red);
            pubIP.IsEnabled = false;

            if (checkI > 0)
            {
                this.frame.Navigate(new LT_PraefixView(this.frame));
            }

            checkI++;
            
        }
    }
}
