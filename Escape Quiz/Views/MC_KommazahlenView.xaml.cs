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
    /// Interaktionslogik für MC_KommazahlenView.xaml
    /// </summary>
    public partial class MC_KommazahlenView : UserControl
    {
        private Frame frame;
        private int checkI;
        public MC_KommazahlenView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            if (checkI==0 && (bool)Int.IsChecked && (bool)Float.IsChecked) { MessageBox.Show("Its right!"); }
            else if(checkI==0) { MessageBox.Show("Leider nicht richtig.\nSchau dir die Lösungen an und gehe dann weiter zur nächsten Aufgabe!"); }

            Int.Foreground = new SolidColorBrush(Colors.Green);
            Int.IsEnabled = false;

            Float.Foreground = new SolidColorBrush(Colors.Green);
            Float.IsEnabled = false;

            Bool.Foreground = new SolidColorBrush(Colors.Red);
            Bool.IsEnabled = false;

            Double.Foreground = new SolidColorBrush(Colors.Red);
            Double.IsEnabled = false;

            if (checkI > 0)
            {
                this.frame.Navigate(new Freitext2View(this.frame));
            }

            checkI++;
            
        }
    }
}
