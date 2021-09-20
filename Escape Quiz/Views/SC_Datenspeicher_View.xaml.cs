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
            
            

            Zahl.Foreground = Score.Right;
            Zahl.IsEnabled = false;

            Bild.Foreground = Score.Wrong;
            Bild.IsEnabled = false;
            Geräusch.Foreground = Score.Wrong;
            Geräusch.IsEnabled = false;
            Wort.Foreground =  Score.Wrong;
            Wort.IsEnabled = false;
            Software.Foreground = Score.Wrong;
            Software.IsEnabled = false;

            
            if(clickI > 0)
            {
                if ((bool)Zahl.IsChecked)
                {
                    Score.OneUp();
                }
                if (Score.GetScore() < 7)
                    this.frame.Navigate(new Freitext1View(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
                
            }

            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
        
    }
