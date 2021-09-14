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
        private int clickI;
        public SC_Datenspeicher_View(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            
            if ((bool)Zahl.IsChecked)
            {
                
            }

            Zahl.Foreground = new SolidColorBrush(Colors.Green);
            Zahl.IsEnabled = false;

            Bild.Foreground = new SolidColorBrush(Colors.Red);
            Bild.IsEnabled = false;
            Geräusch.Foreground = new SolidColorBrush(Colors.Red);
            Geräusch.IsEnabled = false;
            Wort.Foreground = new SolidColorBrush(Colors.Red);
            Wort.IsEnabled = false;
            Software.Foreground = new SolidColorBrush(Colors.Red);
            Software.IsEnabled = false;

            
            if(clickI > 0)
            {
                this.frame.Navigate(new Freitext1View(this.frame));
            }

            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
        
    }
