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

        // Button Click Counter, dass beim ersten Click nur die richtigkeit der Fragen angeteigt wird.
        private int clickI;
        public SC_PrivateIP(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            // Alle RadioButtons werden deaktiviert und erstmal auf Falsch gesetzt.
            privIP.Foreground = Score.Wrong;
            privIP.IsEnabled = false;
            localhost.Foreground = Score.Wrong;
            localhost.IsEnabled = false;
            pubIP.Foreground = Score.Wrong;
            pubIP.IsEnabled = false;
            APIPA.Foreground = Score.Wrong;
            APIPA.IsEnabled = false;


            // wenn der richtige Radio Button angewählt wird, wird dem User angezeigt, dass die richtige Antwort gewählt wurde und der Score wird aktualisiert.
            if ((bool)privIP.IsChecked)
            {
                
                privIP.Foreground = Score.Right;

            }
            if (clickI > 0)
            {
                if((bool)privIP.IsChecked)
                    Score.OneUp();


                /*
                 * Erst wenn die Überprüfung fertig ist, wird der nächste Navigationsschritt getätigt, wenn der benutzer jetzt 7 Punkte hat,
                 * würde das Quiz beendet werden, wenn nicht wird er zur nächsten Frage weitergeleitet.
                 */

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new LT_PraefixView(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
                

            }
            // Wenn der Button geklickt wurde, wird clickI hochgezählt und der neue Content reflecktiert besser, was die Aufgabe des Buttons ist, wenn der button danach geklickt wird.

            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
}
