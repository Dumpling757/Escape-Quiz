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
            int rightI = 0;
            if (clickI == 0)
            {


                
                CheckBox[] checkBoxes = { SuG, Monitor, RAM, Maus, Tastatur, CPU };
                CheckBox[] rightcheckBoxes = { Monitor, Tastatur, Maus };


                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.IsEnabled = false;
                    checkBox.Foreground = Score.Wrong;
                    foreach (CheckBox check in rightcheckBoxes)
                    {
                        if (check == checkBox)
                        {
                            rightI++;
                            checkBox.Foreground = Score.Right;
                        }
                            
                    }
                }

                MessageBox.Show("Leider nicht richtig.\nSchau dir die Lösungen an und gehe dann weiter zur nächsten Aufgabe!");
                if (rightI == 3)
                {
                    // MessageBox.Show("Its right!");
                    Score.OneUp();
                }
            }

            if (clickI > 0) 
            {
                
                if (Score.GetScore() < 7)
                    this.frame.Navigate(new SymbolView(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
            }

            clickI++;
            NextButton.Content = "Nächste Frage";
        }

    }
}
