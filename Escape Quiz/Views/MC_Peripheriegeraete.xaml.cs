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
        private int rightI;
         
        public MC_Peripheriegeraete(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            /*
             * Während des ersten Klicks werden alle Elemente in die entsprechenden Arrays gespeichert.
             */
            if (clickI == 0)
            {
                
                CheckBox[] checkBoxes = { SuG, Monitor, RAM, Maus, Tastatur, CPU };
                CheckBox[] rightcheckBoxes = { Monitor, Tastatur, Maus };

                /*
                 * in der ersten ForEach Schleife werden alle User Interktiven Elemente werden deaktiviert und erstmal auf Falsch gesetzt.
                 */
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.IsEnabled = false;
                    checkBox.Foreground = Score.Wrong;

                    /*
                     *  in dieser ForEach Schleife werden die Checkboxes mit den richtigen Checkboxes verglichen und auf Richtig gesetzt
                     */
                    foreach (CheckBox check in rightcheckBoxes)
                    {
                        if (check == checkBox && (bool)check.IsChecked)
                        {
                            rightI++;
                            checkBox.Foreground = Score.Right;

                        }

                    }
                }

                // Wenn alle drei richtig sind, wird der Score aktualisiert.
                if (rightI == 3)
                {
                    Score.OneUp();

                }

            }


            /*
             * Erst wenn die Überprüfung fertig ist, wird der nächste Navigationsschritt getätigt, wenn der benutzer jetzt 7 Punkte hat,
             * würde das Quiz beendet werden, wenn nicht wird er zur nächsten Frage weitergeleitet.
             */

            if (clickI > 0) 
            {

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new SymbolView(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
            }

            // Wenn der Button geklickt wurde, wird clickI hochgezählt und der neue Content reflecktiert besser, was die Aufgabe des Buttons ist, wenn der button danach geklickt wird.

            clickI++;
            NextButton.Content = "Nächste Frage";
        }

    }
}
