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
    /// Interaktionslogik für MC_Peripheriegeraete.xaml
    /// </summary>
    public partial class MC_Peripheriegeraete : UserControl
    {
        private Frame frame;
        private int clickI;
        public MC_Peripheriegeraete(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            if (clickI==0 &&(bool)Maus.IsChecked && (bool)Monitor.IsChecked && (bool)Tastatur.IsChecked) { MessageBox.Show("Its right!"); }
            else if (clickI == 0) { MessageBox.Show("Leider nicht richtig.\nSchau dir die Lösungen an und gehe dann weiter zur nächsten Aufgabe!"); }

            Brush right = new SolidColorBrush(Colors.Green);
            Brush wrong = new SolidColorBrush(Colors.Red);
            Maus.Foreground = right;
            Maus.IsEnabled = false;

            Monitor.Foreground = right;
            Monitor.IsEnabled = false;

            Tastatur.Foreground = right;
            Tastatur.IsEnabled = false;

            SuG.Foreground = wrong;
            SuG.IsEnabled = false;

            CPU.Foreground = wrong;
            CPU.IsEnabled = false;

            RAM.Foreground = wrong;
            RAM.IsEnabled = false;

            if (clickI > 0) 
            {
                this.frame.Navigate(new SymbolView(this.frame));
            }

            clickI++;
            NextButton.Content = "Nächste Frage";
        }

    }
}
