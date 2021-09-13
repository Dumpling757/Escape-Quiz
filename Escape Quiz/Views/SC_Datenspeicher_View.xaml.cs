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
    /// Interaktionslogik für SC_Datenspeicher_View.xaml
    /// </summary>
    public partial class SC_Datenspeicher_View : UserControl
    {
        private Frame frame;
        private int checkI;
        public SC_Datenspeicher_View(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            if (checkI == 0 && (bool)Zahl.IsChecked) { MessageBox.Show("Its right!"); }
            else if(checkI==0){ MessageBox.Show("Leider nicht richtig.\nSchau dir die Lösungen an und gehe dann weiter zur nächsten Aufgabe!"); }

            Zahl.Foreground = new SolidColorBrush(Colors.Green);
            Zahl.IsEnabled = false;

            Wort.Foreground = new SolidColorBrush(Colors.Red);
            Wort.IsEnabled = false;

            Geraeusch.Foreground = new SolidColorBrush(Colors.Red);
            Geraeusch.IsEnabled = false;

            Bild.Foreground = new SolidColorBrush(Colors.Red);
            Bild.IsEnabled = false;

            Software.Foreground = new SolidColorBrush(Colors.Red);
            Software.IsEnabled = false;

            if (checkI > 0)
            {
                this.frame.Navigate(new Freitext1View(this.frame));
            }

            checkI++;
           
        }
    }
        
    }
